using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DietHolderClient.ServiceReferenceCaloriesCalculator;
using DietHolderClient.ServiceReferenceDatabaseManager;
using DietHolderClient.UserComponents;

namespace DietHolderClient
{
    public partial class MainMenu : Form
    {
        private readonly UcCalorifyCalculator userComponentCalorifyCalculator;
        private readonly UcCalorifyEatenCalculator userComponentCalorifyEatenCalculator;
        private readonly UcVideoPlayer userComponentVideoPlayer;
        private readonly DataTable eatenProductsTable;
        private readonly List<string> motivationalMoviesPlaylist;
        private readonly List<string> educationalMoviesPlaylist;
        private int numberOfMovieToPlay;

        public MainMenu()
        {
            InitializeComponent();

            userComponentCalorifyCalculator = new UcCalorifyCalculator();
            userComponentCalorifyEatenCalculator = new UcCalorifyEatenCalculator();
            userComponentVideoPlayer = new UcVideoPlayer();

            motivationalMoviesPlaylist = CreateMotivationMoviesList();
            educationalMoviesPlaylist = CreateEducationalMoviesList();
            numberOfMovieToPlay = 0;

            eatenProductsTable = CreateEatenProductsTable();

            userComponentCalorifyCalculator.CalculateNeededCalorify += CalculateNeededCalorifyButtonClick;

            userComponentCalorifyEatenCalculator.SearchProduct += SearchProductButtonEvent;
            userComponentCalorifyEatenCalculator.AddProduct += AddProductButtonEvent;
            userComponentCalorifyEatenCalculator.DeleteProduct += DeleteProductButtonEvent;

            userComponentVideoPlayer.NextMovie += NextMovieButtonEvent;
            userComponentVideoPlayer.PreviousMovie += PreviousMovieButtonEvent;
            userComponentVideoPlayer.Switcher += ChangePlaylist;
        }

        private static List<string> CreateEducationalMoviesList()
        {
            var educationalMovies = new List<string>
            {
                "https://www.youtube.com/v/iW52RCL1dGA",
                "https://www.youtube.com/v/uMH9zhHxMlg"
            };
            return educationalMovies;
        }
        private static List<string> CreateMotivationMoviesList()
        {
            var motivationalMovies = new List<string>
            {
                "https://www.youtube.com/v/zh8NkyAsEVM",
                "https://www.youtube.com/v/63bkFs38zjc",
                "https://www.youtube.com/v/0rDh_OSTojQ"
            };
            return motivationalMovies;
        }
        private static DataTable CreateEatenProductsTable()
        {
            var eatenProductsTable = new DataTable();

            var dataColumn1 = new DataColumn("Nazwa produktu", typeof(string));
            var dataColumn2 = new DataColumn("Gramatura", typeof(string));
            var dataColumn3 = new DataColumn("Białko", typeof(string));
            var dataColumn4 = new DataColumn("Węglowodany", typeof(string));
            var dataColumn5 = new DataColumn("Tłuszcze", typeof(string));
            var dataColumn6 = new DataColumn("Kaloryczność", typeof(string));

            eatenProductsTable.Columns.Add(dataColumn1);
            eatenProductsTable.Columns.Add(dataColumn2);
            eatenProductsTable.Columns.Add(dataColumn3);
            eatenProductsTable.Columns.Add(dataColumn4);
            eatenProductsTable.Columns.Add(dataColumn5);
            eatenProductsTable.Columns.Add(dataColumn6);

            return eatenProductsTable;
        }
        private void btn_calculateDailyCaloricNeeds_Click(object sender, EventArgs e)
        {
            BringToFrontOfMainPanel(userComponentCalorifyCalculator);
        }
        private void CalculateNeededCalorifyButtonClick(object sender, EventArgs e)
        {
            Person person;

            try
            {
                person = CreatePerson();
            }
            catch(Exception exception)
            {
                ShowExceptionCommunique(exception);
                return;
            }

            var caloriesCalculator = new CaloriesCalculatorClient();
            var calorify = new Calorify { Calories = caloriesCalculator.GetDailyCaloriesToEatValue(person) };

            userComponentCalorifyCalculator.PersonCaloriesToEatValue = calorify.Calories;

            var macronutrients = caloriesCalculator.GetMacrosDistribution(calorify);
            SetMacronutrientsDistribution(macronutrients);
        }
        private Person CreatePerson()
        {
            var person = new Person
            {
                Age = userComponentCalorifyCalculator.PersonAge,
                Height = userComponentCalorifyCalculator.PersonHeight,
                Weight = userComponentCalorifyCalculator.PersonWeight,
                DailyActivity = userComponentCalorifyCalculator.PersonActivity,
                GoalToRealize = userComponentCalorifyCalculator.PersonGoal,
                KindOfPosture = userComponentCalorifyCalculator.PersonPosture,
                Sex = userComponentCalorifyCalculator.IsWoman ? "Kobieta" : "Mezczyzna"
            };
            return person;
        }
        private static void ShowExceptionCommunique(Exception exception)
        {
            if(exception is ArgumentNullException || exception is FormatException)
            {
                MessageBox.Show(@"Proszę o poprawne wypełnienie każdego z pół formularza",
                    @"Komunikat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show(exception.ToString());
        }
        private void SetMacronutrientsDistribution(Dictionary<string, double> macronutrients)
        {
            userComponentCalorifyCalculator.CarboValue = macronutrients["Węglowodany"];
            userComponentCalorifyCalculator.ProteinValue = macronutrients["Białko"];
            userComponentCalorifyCalculator.FatValue = macronutrients["Tłuszcze"];
        }
        private void btn_calculateDailyCaloricIntake_Click(object sender, EventArgs e)
        {
            BringToFrontOfMainPanel(userComponentCalorifyEatenCalculator);
        }
        private void SearchProductButtonEvent(object sender, EventArgs e)
        {
            var productToSearch = userComponentCalorifyEatenCalculator.ProductNameToSearch;

            userComponentCalorifyEatenCalculator.ProductTableSearchResults
                = SearchProductInDataTable(productToSearch);
            Cb_productChoice_UpdateItemsCollection();
        }
        private static DataTable SearchProductInDataTable(string productName)
        {
            var databaseManager = new DatabaseManagerClient();
            var dataToInteract = new DataToInteractWithDatabase
            {
                ProductName = productName
            };
            var searchResults = databaseManager.SearchProduct(dataToInteract);

            return searchResults;
        }
        private void Cb_productChoice_UpdateItemsCollection()
        {
            var productsList = new List<string>();
            var productsTable = userComponentCalorifyEatenCalculator.ProductTableSearchResults as DataTable;

            if(productsTable != null)
                for(int rowsInDataTable = 0; rowsInDataTable < productsTable.Rows.Count; rowsInDataTable++)
                {
                    productsList.Add(productsTable.Rows[rowsInDataTable][1].ToString());
                }

            userComponentCalorifyEatenCalculator.ProductsList = productsList;
        }
        private void AddProductButtonEvent(object sender, EventArgs e)
        {
            AddEatenProduct();
            CreateSummaryOfEatenCalories();
            cb_productToDelete_UpdateItemsCollection();
        }
        private void AddEatenProduct()
        {
            var newRowOfEatenProducts = CreateNewRowOfEatenProducts();

            eatenProductsTable.Rows.Add(newRowOfEatenProducts);
            userComponentCalorifyEatenCalculator.ProductTableEatenProducts = eatenProductsTable;
        }
        private DataRow CreateNewRowOfEatenProducts()
        {
            var nameOfProductToAdd = userComponentCalorifyEatenCalculator.ProductToAdd;
            var productWeight = userComponentCalorifyEatenCalculator.ProductWeight;
            var resultsOfSearch = SearchProductInDataTable(nameOfProductToAdd);

            var newRowOfEatenProducts = eatenProductsTable.NewRow();
            resultsOfSearch.Columns.RemoveAt(0);

            newRowOfEatenProducts[0] = resultsOfSearch.Rows[0][0];
            newRowOfEatenProducts[1] = productWeight;
            newRowOfEatenProducts[2] =
                CalculateEatenMacronutrients(double.Parse(resultsOfSearch.Rows[0][1].ToString()),
                    double.Parse(productWeight));
            newRowOfEatenProducts[3] =
                CalculateEatenMacronutrients(double.Parse(resultsOfSearch.Rows[0][2].ToString()),
                    double.Parse(productWeight));
            newRowOfEatenProducts[4] =
                CalculateEatenMacronutrients(double.Parse(resultsOfSearch.Rows[0][3].ToString()),
                    double.Parse(productWeight));
            newRowOfEatenProducts[5] =
                CalculateEatenMacronutrients(double.Parse(resultsOfSearch.Rows[0][4].ToString()),
                    double.Parse(productWeight));
            return newRowOfEatenProducts;
        }
        private static double CalculateEatenMacronutrients(double productMacro, double productWeight)
        {
            return productMacro * productWeight * 0.01;
        }
        private void CreateSummaryOfEatenCalories()
        {
            var eatenMacronutrients = new Dictionary<string, double>
            {
                ["Węglowodany"] = 0,
                ["Białko"] = 0,
                ["Tłuszcze"] = 0
            };
            UpdateEatenMacronutrients(eatenMacronutrients);

            var eatenCalorifySummary = CreateTableEatenCalorifySummary();
            var eatenCalorify = CalculateEatenCalorify();
            var eatenCalorifySummaryNewRow =
                CreateNewRowOfEatenCalorifySummary(eatenCalorifySummary, eatenMacronutrients, eatenCalorify);

            eatenCalorifySummary.Rows.Add(eatenCalorifySummaryNewRow);
            userComponentCalorifyEatenCalculator.ProductTableEatenCalorify = eatenCalorifySummary;
        }
        private void UpdateEatenMacronutrients(Dictionary<string, double> eatenMacronutrients)
        {
            for(int eatenProductTableRow = 0;
                eatenProductTableRow < eatenProductsTable.Rows.Count;
                eatenProductTableRow++)
            {
                eatenMacronutrients["Białko"] +=
                    Convert.ToDouble(eatenProductsTable.Rows[eatenProductTableRow]["Białko"]);
                eatenMacronutrients["Węglowodany"] +=
                    Convert.ToDouble(eatenProductsTable.Rows[eatenProductTableRow]["Węglowodany"]);
                eatenMacronutrients["Tłuszcze"] +=
                    Convert.ToDouble(eatenProductsTable.Rows[eatenProductTableRow]["Tłuszcze"]);
            }
        }
        private static DataTable CreateTableEatenCalorifySummary()
        {
            var eatenCalorifySummary = new DataTable();

            var dataColumn1 = new DataColumn("Bialko", typeof(string));
            var dataColumn2 = new DataColumn("Węglowodany", typeof(string));
            var dataColumn3 = new DataColumn("Tłuszcze", typeof(string));
            var dataColumn4 = new DataColumn("Kalorie", typeof(string));

            eatenCalorifySummary.Columns.Add(dataColumn1);
            eatenCalorifySummary.Columns.Add(dataColumn2);
            eatenCalorifySummary.Columns.Add(dataColumn3);
            eatenCalorifySummary.Columns.Add(dataColumn4);

            return eatenCalorifySummary;
        }
        private double CalculateEatenCalorify()
        {
            double eatenCalorify = 0;

            for(int eatenProductTableRow = 0;
                eatenProductTableRow < eatenProductsTable.Rows.Count;
                eatenProductTableRow++)
            {
                eatenCalorify += Convert.ToDouble(eatenProductsTable.Rows[eatenProductTableRow]["Kaloryczność"]);
            }
            return eatenCalorify;
        }
        private static DataRow CreateNewRowOfEatenCalorifySummary(DataTable eatenCalorifySummary,
            Dictionary<string, double> eatenMacronutrients, double eatenCalorify)
        {
            var eatenCalorifySummaryTableNewRow = eatenCalorifySummary.NewRow();
            eatenCalorifySummaryTableNewRow[0] = eatenMacronutrients["Białko"];
            eatenCalorifySummaryTableNewRow[1] = eatenMacronutrients["Węglowodany"];
            eatenCalorifySummaryTableNewRow[2] = eatenMacronutrients["Tłuszcze"];
            eatenCalorifySummaryTableNewRow[3] = eatenCalorify;
            return eatenCalorifySummaryTableNewRow;
        }
        private void cb_productToDelete_UpdateItemsCollection()
        {
            var eatenProductsList = new List<string>();

            for(int productsQuantity = 0; productsQuantity < eatenProductsTable.Rows.Count; productsQuantity++)
            {
                eatenProductsList.Add(eatenProductsTable.Rows[productsQuantity]["Nazwa produktu"].ToString());
            }
            userComponentCalorifyEatenCalculator.AddedProductsList = eatenProductsList;
        }
        private void DeleteProductButtonEvent(object sender, EventArgs e)
        {
            DeleteProductFromTable();
            CreateSummaryOfEatenCalories();
            cb_productToDelete_UpdateItemsCollection();
        }
        private void DeleteProductFromTable()
        {
            var nameOfProductToDelete = userComponentCalorifyEatenCalculator.ProductToDelete;
            try
            {
                var tableRow = eatenProductsTable
                    .AsEnumerable()
                    .First(x => x.Field<string>("Nazwa produktu") == nameOfProductToDelete);

                eatenProductsTable.Rows.Remove(tableRow);
            }
            catch(Exception)
            {
                ShowDeleteAlertMessage();
            }
            userComponentCalorifyEatenCalculator.ProductTableEatenProducts = eatenProductsTable;
        }
        private static void ShowDeleteAlertMessage()
        {
            MessageBox.Show(@"Usuwanie nie może zostać zrealizowane",
                @"Komunikat",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
        private void btn_dietStatistics_Click(object sender, EventArgs e)
        {
            if(CreateDietStatistics() == null)
                return;

            var userComponentDietStatistics = CreateDietStatistics();
            BringToFrontOfMainPanel(userComponentDietStatistics);
        }
        private UcDietStatistics CreateDietStatistics()
        {
            var eatenCalorify = CalculateEatenCalorify();
            if(eatenCalorify != 0)
            {
                Person person;
                try
                {
                    person = CreatePerson();
                }
                catch(Exception exception)
                {
                    ShowExceptionCommunique(exception);
                    return null;
                }

                var eatenMacros = new Dictionary<string, double>
                {
                    ["Węglowodany"] = 0,
                    ["Białko"] = 0,
                    ["Tłuszcze"] = 0
                };

                var caloriesCalculator = new CaloriesCalculatorClient();
                var calorify = new Calorify { Calories = caloriesCalculator.GetDailyCaloriesToEatValue(person) };
                var macrosDistribution = caloriesCalculator.GetMacrosDistribution(calorify);
                var caloriesRemainedToEat = calorify.Calories - eatenCalorify;

                UpdateEatenMacronutrients(eatenMacros);

                var carbosRemainedToEat =
                    macrosDistribution["Węglowodany"] - eatenMacros["Węglowodany"];
                var proteinRemainedToEat = macrosDistribution["Białko"] - eatenMacros["Białko"];
                var fatRemainedToEat = macrosDistribution["Tłuszcze"] - eatenMacros["Tłuszcze"];

                if(caloriesRemainedToEat < 0)
                {
                    caloriesRemainedToEat = 0;
                }

                var remainedCalorifyToEat =
                    $"Węglowodany: {carbosRemainedToEat} gram, białko {proteinRemainedToEat} gram, tłuszcze {fatRemainedToEat} gram";
                var eatedCalorifyValue =
                    $"Węglowodany: {eatenMacros["Węglowodany"]} gram, białko {eatenMacros["Białko"]} gram, tłuszcze {eatenMacros["Tłuszcze"]} gram";

                var userControlDietStatistics = new UcDietStatistics(
                    eatenMacros["Węglowodany"],
                    eatenMacros["Białko"],
                    eatenMacros["Tłuszcze"],
                    caloriesRemainedToEat)
                {
                    RemainedCalorifyToEat = remainedCalorifyToEat,
                    EatedCalorifyValue = eatedCalorifyValue
                };
                return userControlDietStatistics;
            }
            EatenCalorifyAlertMessage();
            return null;
        }
        private static void EatenCalorifyAlertMessage()
        {
            MessageBox.Show(@"Nieznane zapotrzebowanie kaloryczne, proszę o wypełnienie formularza",
                @"Komunikat",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
        private void NextMovieButtonEvent(object sender, EventArgs e)
        {
            btn_dietStatistics.Text = userComponentVideoPlayer.GetPositionOfSwitcher;
            numberOfMovieToPlay++;
            switch(userComponentVideoPlayer.GetPositionOfSwitcher)
            {
                case @"Motywacja":
                    if(IsAvaibleToPlayNextMovie(motivationalMoviesPlaylist, numberOfMovieToPlay))
                    {
                        PlayMovie(motivationalMoviesPlaylist, numberOfMovieToPlay);
                    }
                    else
                    {
                        MovieIsOutOfThePlaylistAlert();
                        numberOfMovieToPlay--;
                    }
                    break;
                case @"Nauka":
                    if(IsAvaibleToPlayNextMovie(educationalMoviesPlaylist, numberOfMovieToPlay))
                    {
                        PlayMovie(educationalMoviesPlaylist, numberOfMovieToPlay);
                    }
                    else
                    {
                        MovieIsOutOfThePlaylistAlert();
                        numberOfMovieToPlay--;
                    }
                    break;
            }
        }
        private static bool IsAvaibleToPlayNextMovie(List<string> moviesPlaylist, int positionOfMovieToPlay)
        {
            if(positionOfMovieToPlay >= moviesPlaylist.Count)
            {
                return false;
            }
            return true;
        }
        private static bool IsAvaibleToPlayPreviousMovie(int positionOfMovieToPlay)
        {
            if(positionOfMovieToPlay < 0)
            {
                return false;
            }
            return true;
        }
        private static void MovieIsOutOfThePlaylistAlert()
        {
            MessageBox.Show(@"Zadana pozycja znajduje się poza playlistą filmów.");
        }
        private void PlayMovie(List<string> moviesPlaylist, int positionOfMovieToPlay)
        {
            userComponentVideoPlayer.MovieTitle = moviesPlaylist[positionOfMovieToPlay];
            userComponentVideoPlayer.Refresh();
        }
        private void PreviousMovieButtonEvent(object sender, EventArgs e)
        {
            numberOfMovieToPlay--;
            switch(userComponentVideoPlayer.GetPositionOfSwitcher)
            {
                case @"Nauka":
                    if(IsAvaibleToPlayPreviousMovie(numberOfMovieToPlay))
                    {
                        PlayMovie(motivationalMoviesPlaylist, numberOfMovieToPlay);
                    }
                    else
                    {
                        MovieIsOutOfThePlaylistAlert();
                        numberOfMovieToPlay++;
                    }
                    break;
                case @"Motywacja":
                    if(IsAvaibleToPlayPreviousMovie(numberOfMovieToPlay))
                    {
                        PlayMovie(educationalMoviesPlaylist, numberOfMovieToPlay);
                    }
                    else
                    {
                        MovieIsOutOfThePlaylistAlert();
                        numberOfMovieToPlay++;
                    }
                    break;
            }
        }
        private void ChangePlaylist(object sender, EventArgs e)
        {
            LoadMoviePlaylist();
        }
        private void LoadMoviePlaylist()
        {
            switch(userComponentVideoPlayer.GetPositionOfSwitcher)
            {
                case @"Nauka":
                    userComponentVideoPlayer.MovieTitle = motivationalMoviesPlaylist[0];
                    userComponentVideoPlayer.Refresh();
                    break;
                case @"Motywacja":
                    userComponentVideoPlayer.MovieTitle = educationalMoviesPlaylist[0];
                    userComponentVideoPlayer.Refresh();
                    break;
            }
            numberOfMovieToPlay = 0;
        }
        private void btn_moviePlayer_Click(object sender, EventArgs e)
        {
            BringToFrontOfMainPanel(userComponentVideoPlayer);
            LoadMoviePlaylist();
        }
        private void BringToFrontOfMainPanel(UserControl controlToBring)
        {
            if(controlToBring == null)
                throw new ArgumentNullException(nameof(controlToBring));
            panel_mainPanel.Controls.Clear();
            panel_mainPanel.Controls.Add(controlToBring);
            controlToBring.Dock = DockStyle.Fill;
            controlToBring.BringToFront();
        }
    }
}
