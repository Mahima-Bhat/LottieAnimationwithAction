using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Windows.Input;
using Lottie.Forms;
using LottieAnimationEx;
using Xamarin.Forms;

namespace LottieAnimationEx.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public ICommand ButtonClickCommand { get; set; }

        private bool _isAnimationVisible;

        private bool _isAnimationInProgress;

        private bool _isButtonVisible = true;




        public bool IsButtonVisible
        {
            get
            {
                return _isButtonVisible;
            }
            set
            {
                _isButtonVisible = value;
                OnPropertyChangedForButtonVisible(nameof(IsButtonVisible));
            }
        }

        private void OnPropertyChangedForButtonVisible(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool IsAnimationVisible
        {
            get
            {
                return _isAnimationVisible;

            }

            set
            {
                _isAnimationVisible = value;
                OnPropertyChangedForAnimation(nameof(IsAnimationVisible));
            }
        }

        
        
        public bool IsButtonClicked
        {
            get
            {
                return _isButtonClicked;
            }
            set
            {
                _isButtonClicked = value;
                OnPropertyChanged(nameof(IsButtonClicked));
            }

        }

        private void OnPropertyChanged(string IsButtonClicked)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(IsButtonClicked));
        }

        private void OnPropertyChangedForAnimation(string IsAnimationVisible)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(IsAnimationVisible));
        }



        private bool _isButtonClicked;


        public MainPageViewModel()
        {
            ButtonClickCommand = new Command(ChangeAnimation);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
        private void ChangeAnimation()
        {
           

            if (!_isAnimationInProgress)
            {
                _isAnimationInProgress = true;
                IsButtonVisible = false;
                IsButtonClicked = !IsButtonClicked;
                IsAnimationVisible = !IsAnimationVisible;
                Thread.Sleep(5000);
                //IsButtonClicked = !IsButtonClicked;
                //IsAnimationVisible = IsAnimationVisible;
                _isAnimationInProgress = false;
                

            }

            IsButtonVisible = true;

        }


       

       
    }
}
