using GreyHoundApp.Data.DogClass;
using GreyHoundApp.WPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace GreyHoundApp.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        List<DogModelClass> myListOfDogs = new List<DogModelClass>();
        bool winflag = false;

        public MainWindow()
        {
            InitializeComponent();

            InitializeTimer();

            DogBaseClass dog;
            dog = DogGeneratorClass.FactoryMethod(DogGeneratorClass.BEAGLE, "Be");
            CreateDogModel(3, 7, dog);

            dog = DogGeneratorClass.FactoryMethod(DogGeneratorClass.BULLDOG, "Bull");
            CreateDogModel(45, 7, dog);

            dog = DogGeneratorClass.FactoryMethod(DogGeneratorClass.GERMAN_SHEPHARD, "GS");
            CreateDogModel(90, 7, dog);
            //

            dog = DogGeneratorClass.FactoryMethod(DogGeneratorClass.GREAT_PYTENEES, "BIG");
            CreateDogModel(130, 7, dog);

            InitializeDogModelPosition();
        }
        /// <summary>
        /// Initialize the timer control
        /// </summary>
        private void InitializeTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 50);
        }

        private void CreateDogModel(int Top, int Left, DogBaseClass dog)
        {
            DogModelClass dogmodel;
            dogmodel = new DogModelClass(dog);
            dogmodel.callBackMethod = displayImage;
            dogmodel.Top = Top;
            dogmodel.Left = Left;

            //Canvas.SetTop(dogmodel.image, Top);
            //Canvas.SetLeft(dogmodel.image, Left);
            myCanvas.Children.Add(dogmodel.image);

            timer.Tick += new EventHandler(dogmodel.Move);

            myListOfDogs.Add(dogmodel);
        }

        private void InitializeDogModelPosition()
        {
            //throw new NotImplementedException();

            foreach (DogModelClass model in myListOfDogs)
            {
                Canvas.SetTop(model.image, model.Top);
                Canvas.SetLeft(model.image, model.Left);
            }

            winflag = false;
        }

        void displayImage(DogModelClass dog, int id)
        {
            if (winflag)
            {
                timer.Stop();
                return;
            }


            Image image = dog.image;
            long dogPos = Convert.ToInt64(image.GetValue(Canvas.LeftProperty));//calculating the dog postion with respect to left property

            if (dogPos >= RaceTrack.Width - image.Width) //800 is the width of the panel
            {
                //Canvas.SetLeft(dog1, 12);
                timer.Stop();
                if (!winflag)
                {
                    MessageBox.Show($"Dog {id} has won!!!");
                    winflag = true;
                    InitializeDogModelPosition();
                }
            }
            else
            {
                int pace = DogGeneratorClass.GenerateSteps(dog as DogBaseClass);
                Canvas.SetLeft(image, dogPos + pace);

            }
        }

        private void RaceButton_Click(object sender, RoutedEventArgs e)
        {
            //InitializeDogModelPosition();
            timer.Start();
        }
    }
}
