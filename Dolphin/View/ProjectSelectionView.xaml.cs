using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace View
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ProjectSelectionView : UserControl
    {
        public ProjectSelectionView()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty ClassificationSelectionCommandProperty = DependencyProperty.Register("ClassificationSelectionCommand", typeof(ICommand), typeof(ProjectSelectionView));
        public ICommand ClassificationSelectionCommand
        {
            get
            {
                return (ICommand)GetValue(ClassificationSelectionCommandProperty);
            }

            set
            {
                SetValue(ClassificationSelectionCommandProperty, value);
            }
        }

        public static readonly DependencyProperty SegmentationSelectionCommandProperty = DependencyProperty.Register("SegmentationSelectionCommand", typeof(ICommand), typeof(ProjectSelectionView));
        public ICommand SegmentationSelectionCommand
        {
            get
            {
                return (ICommand)GetValue(SegmentationSelectionCommandProperty);
            }

            set
            {
                SetValue(SegmentationSelectionCommandProperty, value);
            }
        }

        public static readonly DependencyProperty ObjectDetectionSelectionCommandProperty = DependencyProperty.Register("ObjectDetectionSelectionCommand", typeof(ICommand), typeof(ProjectSelectionView));
        public ICommand ObjectDetectionSelectionCommand
        {
            get
            {
                return (ICommand)GetValue(ObjectDetectionSelectionCommandProperty);
            }

            set
            {
                SetValue(ObjectDetectionSelectionCommandProperty, value);
            }
        }


        public static readonly DependencyProperty OpenProjectCommandProperty = DependencyProperty.Register("OpenProjectCommand", typeof(ICommand), typeof(ProjectSelectionView));
        public ICommand OpenProjectCommand
        {
            get
            {
                return (ICommand)GetValue(OpenProjectCommandProperty);
            }

            set
            {
                SetValue(OpenProjectCommandProperty, value);
            }
        }
    }
}