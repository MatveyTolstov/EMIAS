using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Media;

namespace EMIAS.ViewModel
{
    public class AppointmentDocBlackViewModel : INotifyPropertyChanged
    {
        private double _buttonWidth = 97;
        private double _buttonHeight = 80;
        private double _stackPanelWidth = 80;
        private double _stackPanelHeight = 50;
        private double _imageHeight = 30;
        private double _textSize = 10;
        private Brush _buttonColor = Brushes.White;
        private Brush _backgroundColor = Brushes.LightGray;
        private Brush _scrollViewerColor = Brushes.LightGray;
        private Brush _scrollBarColor = Brushes.White;

        public double ButtonWidth
        {
            get { return _buttonWidth; }
            set
            {
                if (_buttonWidth != value)
                {
                    _buttonWidth = value;
                    OnPropertyChanged(nameof(ButtonWidth));
                }
            }
        }

        public double ButtonHeight
        {
            get { return _buttonHeight; }
            set
            {
                if (_buttonHeight != value)
                {
                    _buttonHeight = value;
                    OnPropertyChanged(nameof(ButtonHeight));
                }
            }
        }

        public double StackPanelWidth
        {
            get { return _stackPanelWidth; }
            set
            {
                if (_stackPanelWidth != value)
                {
                    _stackPanelWidth = value;
                    OnPropertyChanged(nameof(StackPanelWidth));
                }
            }
        }

        public double StackPanelHeight
        {
            get { return _stackPanelHeight; }
            set
            {
                if (_stackPanelHeight != value)
                {
                    _stackPanelHeight = value;
                    OnPropertyChanged(nameof(StackPanelHeight));
                }
            }
        }

        public double ImageHeight
        {
            get { return _imageHeight; }
            set
            {
                if (_imageHeight != value)
                {
                    _imageHeight = value;
                    OnPropertyChanged(nameof(ImageHeight));
                }
            }
        }

        public double TextSize
        {
            get { return _textSize; }
            set
            {
                if (_textSize != value)
                {
                    _textSize = value;
                    OnPropertyChanged(nameof(TextSize));
                }
            }
        }

        public Brush ButtonColor
        {
            get { return _buttonColor; }
            set
            {
                if (_buttonColor != value)
                {
                    _buttonColor = value;
                    OnPropertyChanged(nameof(ButtonColor));
                }
            }
        }

        public Brush BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                if (_backgroundColor != value)
                {
                    _backgroundColor = value;
                    OnPropertyChanged(nameof(BackgroundColor));
                }
            }
        }

        public Brush ScrollViewerColor
        {
            get { return _scrollViewerColor; }
            set
            {
                if (_scrollViewerColor != value)
                {
                    _scrollViewerColor = value;
                    OnPropertyChanged(nameof(ScrollViewerColor));
                }
            }
        }

        public Brush ScrollBarColor
        {
            get { return _scrollBarColor; }
            set
            {
                if (_scrollBarColor != value)
                {
                    _scrollBarColor = value;
                    OnPropertyChanged(nameof(ScrollBarColor));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
