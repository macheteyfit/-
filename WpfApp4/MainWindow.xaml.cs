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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private void update_size(object sender, RoutedEventArgs e)
        //{
        //    textBlock.Text = getText();
        //}

        //private string getText()
        //{
        //    return $"ActualWhiht{textBlock.ActualWidth}\n" +
        //           $"ActualHeight{textBlock.ActualHeight}"; 
        //}
        public MainWindow()
        {
            InitializeComponent();
            //textBlock.Text = getText();
            //this.SizeChanged += update_size;
        }
    }
}


//< !--< Grid.ColumnDefinitions >
//    < ColumnDefinition Width = "*" />
//    < ColumnDefinition Width = "*" />
//    < ColumnDefinition Width = "*" />
//</ Grid.ColumnDefinitions >
//< Grid.RowDefinitions >
//    < RowDefinition Height = "*" />
//    < RowDefinition Height = "*" />
//    < RowDefinition Height = "*" />
//</ Grid.RowDefinitions >
//< Button Grid.ColumnSpan = "2" > Button 1 </ Button >
//< Button Grid.Column = "3" > Button 2 </ Button >
//< Button Grid.Row = "1" > Button 3 </ Button >
//< Button Grid.Column = "1" Grid.Row = "1" Grid.RowSpan = "2" Grid.ColumnSpan = "2" > Button 4 </ Button >
//< Button Grid.Column = "0" Grid.Row = "2" > Button 5 </ Button >



//< !--< Grid.ColumnDefinitions >
//    < ColumnDefinition Width = "1" />
//    < ColumnDefinition Width = "Auto" />
//    < ColumnDefinition Width = "100" />
//</ Grid.ColumnDefinitions >
//< Button > Button 1 </ Button >
//< Button Grid.Column = "1" > Button 2 with long text</ Button >
//< Button Grid.Column = "2" > Button 3 </ Button > -->
//< !--< Button
//    VerticalAlignment = "Center"
//    HorizontalAlignment = "Center" > Button 1 </ Button >
//< Button Grid.Column = "1"
//        VerticalAlignment = "Center"
//        HorizontalAlignment = "Center" > Button 2 </ Button >
//< Button Grid.Column = "2"
//        VerticalAlignment = "Center"
//        HorizontalAlignment = "Center" > Button 3 </ Button > -->
//< !--< Grid.RowDefinitions >
//    < RowDefinition Height = "2*" />
//    < RowDefinition Height = "*" />
//    < RowDefinition Height = "*" />
//</ Grid.RowDefinitions >
//< Button > Button 1 </ Button >
//< Button Grid.Column = "1" > Button 2 </ Button >
//< Button Grid.Column = "2" > Button 3 </ Button >
//< Button Grid.Row = "1" > Button 4 </ Button >
//< Button Grid.Row = "2" > Button 7 </ Button >
//< Button Grid.Row = "2" Grid.Column = "1" > Button 8 </ Button >
//< Button Grid.Row = "2" Grid.Column = "2" > Button 9 </ Button >
//< Button Grid.Row = "1" Grid.Column = "1" > Button 5 </ Button >
//< Button Grid.Row = "1" Grid.Column = "2" > Button 6 </ Button > -->


/*
   <Grid.ColumnDefinitions>
<ColumnDefinition Width="*" />
<ColumnDefinition Width="5" />            
<ColumnDefinition Width="*" />            
</Grid.ColumnDefinitions>
<Grid.RowDefinitions>
<RowDefinition Height="*" />
<RowDefinition Height="5" />
<RowDefinition Height="*" />
</Grid.RowDefinitions>
<TextBlock Grid.Column="0" FontSize="55" TextWrapping="Wrap">Left side</TextBlock>
<TextBlock Grid.Row="2" Grid.Column="0" FontSize="55" TextWrapping="Wrap">Left side</TextBlock>
<GridSplitter Grid.Column="1" Grid.RowSpan="3" FontSize="5" HorizontalAlignment="Stretch" />
<GridSplitter Grid.Row="1" Grid.ColumnSpan="3" FontSize="5" HorizontalAlignment="Stretch" />
<GridSplitter Grid.Row="1" FontSize="5" HorizontalAlignment="Stretch" />
<TextBlock Grid.Column="2" FontSize="55" TextWrapping="Wrap">Right side</TextBlock>
<TextBlock Grid.Row="2" Grid.Column="2" FontSize="55" TextWrapping="Wrap">Right side</TextBlock>

 */

/*
 <Grid>
<Grid.ColumnDefinitions>
<ColumnDefinition Width="Auto" />
<ColumnDefinition Width="*" />
</Grid.ColumnDefinitions>        
<Grid.RowDefinitions>
<RowDefinition Height="Auto" />
<RowDefinition Height="Auto" />
<RowDefinition Height="*" />
</Grid.RowDefinitions>
<TextBlock FontSize="24">Name:</TextBlock>
<TextBox FontSize="24"
     Grid.Column="1"></TextBox>
<TextBlock FontSize="24" Grid.Row="1">E-mail</TextBlock>
<TextBox  FontSize="24"  Grid.Column="1" Grid.Row="1"></TextBox>
<TextBox  FontSize="24"  Grid.ColumnSpan="2" Grid.Row="2"></TextBox>       
</Grid>
 */



