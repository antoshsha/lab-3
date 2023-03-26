using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using static lab_3.Errors;

namespace lab_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void proceed_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if ((string.IsNullOrWhiteSpace(name_box.Text)) && (string.IsNullOrWhiteSpace(lastname_box.Text)) && (string.IsNullOrWhiteSpace(email_box.Text)) && (string.IsNullOrWhiteSpace(dtpicker.ToString())))
                {
                    proceed_button.IsEnabled = true;
                }


                Person person1 = new Person(name_box.Text, lastname_box.Text, email_box.Text, dtpicker.SelectedDate.Value);
                name_res.Text = "Name: " + person1.Name;
                lastname_res.Text = "Last name: " + person1.LastName;
                email_res.Text = "Email " + person1.Email;
                date_res.Text = "Date of birth " + person1.BirthDate.ToString();
                isadult_res.Text = "Is the person an adult? " + person1.IsAdult;
                isbirthday_res.Text = "Is today a person's birthday? " + person1.IsBirthday;
                chinese_res.Text = "Chinese sign: " + person1.ChineseSign;
                sunsign_res.Text = "Sun sign: " + person1.SunSign;


                if ((DateTime.Now.Year - dtpicker.SelectedDate.Value.Year > 135) || (DateTime.Now.Year - dtpicker.SelectedDate.Value.Year < 0))
                {
                    MsgBoxResult msgBoxResult = (MsgBoxResult)MessageBox.Show("you entered a fake date", "error");
                    name_res.Text = "Name: ";
                    lastname_res.Text = "Last name: ";
                    email_res.Text = "Email ";
                    date_res.Text = "Date of birth ";
                    isadult_res.Text = "Is the person an adult? ";
                    isbirthday_res.Text = "Is today a person's birthday? ";
                    chinese_res.Text = "Chinese sign: ";
                    sunsign_res.Text = "Sun sign: ";
                    birthday.Text = "";
                }
                if ((DateTime.Now.Year - dtpicker.SelectedDate.Value.Year == 0))
                {
                    if (DateTime.Now.Month < dtpicker.SelectedDate.Value.Month)
                    {
                        MsgBoxResult msgBoxResult = (MsgBoxResult)MessageBox.Show("you entered a fake date", "error");
                        name_res.Text = "Name: ";
                        lastname_res.Text = "Last name: ";
                        email_res.Text = "Email ";
                        date_res.Text = "Date of birth ";
                        isadult_res.Text = "Is the person an adult? ";
                        isbirthday_res.Text = "Is today a person's birthday? ";
                        chinese_res.Text = "Chinese sign: ";
                        sunsign_res.Text = "Sun sign: ";
                        birthday.Text = "";

                    }
                    if (DateTime.Now.Month == dtpicker.SelectedDate.Value.Month)
                    {

                        if (DateTime.Now.Day < dtpicker.SelectedDate.Value.Day)
                        {
                            MsgBoxResult msgBoxResult = (MsgBoxResult)MessageBox.Show("you entered a fake date", "error");
                            name_res.Text = "Name: ";
                            lastname_res.Text = "Last name: ";
                            email_res.Text = "Email: ";
                            date_res.Text = "Date of birth ";
                            isadult_res.Text = "Is the person an adult? ";
                            isbirthday_res.Text = "Is today a person's birthday? ";
                            chinese_res.Text = "Chinese sign: ";
                            sunsign_res.Text = "Sun sign: ";
                            birthday.Text = "";
                        }
                    }

                }
                if (person1.IsBirthday == true)
                {

                    birthday.Text = "happy birthday!";
                }
                else
                {

                    birthday.Text = "";
                }
            }
            catch (EarlyDateError ex) { 
            Trace.WriteLine(ex.message);
            }
            catch (LateDateError ex)
            {
                Trace.WriteLine(ex.message);
            }
            catch (EmailFormat ex)
            {
                Trace.WriteLine(ex.message);
            }
            catch (NameFormat ex)
            {
                Trace.WriteLine(ex.message);
            }
            catch (LastNameFormat ex)
            {
                Trace.WriteLine(ex.message);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
        }



        private void name_box_TextChanged(object sender, TextChangedEventArgs e)
        {


            if ((string.IsNullOrWhiteSpace(name_box.Text)) || (string.IsNullOrWhiteSpace(lastname_box.Text)) || (string.IsNullOrWhiteSpace(email_box.Text)) || (string.IsNullOrWhiteSpace(dtpicker.ToString())))
            {

                proceed_button.IsEnabled = false;
            }
            else
            {

                proceed_button.IsEnabled = true;
            }


        }

        private void lastname_box_TextChanged(object sender, TextChangedEventArgs e)
        {


            if ((string.IsNullOrWhiteSpace(name_box.Text)) || (string.IsNullOrWhiteSpace(lastname_box.Text)) || (string.IsNullOrWhiteSpace(email_box.Text)) || (string.IsNullOrWhiteSpace(dtpicker.ToString())))
            {

                proceed_button.IsEnabled = false;
            }
            else
            {

                proceed_button.IsEnabled = true;
            }


        }

        private void email_box_TextChanged(object sender, TextChangedEventArgs e)
        {


            if ((string.IsNullOrWhiteSpace(name_box.Text)) || (string.IsNullOrWhiteSpace(lastname_box.Text)) || (string.IsNullOrWhiteSpace(email_box.Text)) || (string.IsNullOrWhiteSpace(dtpicker.ToString())))
            {

                proceed_button.IsEnabled = false;
            }
            else
            {

                proceed_button.IsEnabled = true;
            }


        }

        private void dtpicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {


            if ((string.IsNullOrWhiteSpace(name_box.Text)) || (string.IsNullOrWhiteSpace(lastname_box.Text)) || (string.IsNullOrWhiteSpace(email_box.Text)) || (string.IsNullOrWhiteSpace(dtpicker.ToString())))
            {

                proceed_button.IsEnabled = false;
            }
            else
            {

                proceed_button.IsEnabled = true;
            }

        } }
    
    }



