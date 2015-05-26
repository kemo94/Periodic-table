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
using System.Windows.Shapes;
using System.Speech;
using System.Speech.Synthesis;

namespace chemicals
{
    /// <summary>
    /// Interaction logic for Chemical_elements.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        SpeechSynthesizer reader = new SpeechSynthesizer();
        private void Button_Click_3(object sender, RoutedEventArgs e) // H
        {

         
            reader.SpeakAsync("Hydrogen");

            labelesm.Content = "هيدروجين";//الاسم
            labelesm_Copy.Content = "1";//العدد
            labelesm_Copy1.Content = "H";//الرمز
            labelesm_Copy2.Content = " لا فلز";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "1.00794";// الكتلة الذرية
            labelesm_Copy4.Content = "1s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "s";//المستوى الفرعي 
            labelesm_Copy6.Content = "1";//المجموعة
            labelesm_Copy7.Content = "1";//الدورة
            labelesm_Copy3.Content = "               1";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "H.jpg", UriKind.Relative));

        }

        private void Button_Click_4(object sender, RoutedEventArgs e) //Na
        {
            reader.SpeakAsync("Sodium");
           
            labelesm.Content = "صوديوم";//الاسم
            labelesm_Copy.Content = "11";//العدد
            labelesm_Copy1.Content = "Na";//الرمز
            labelesm_Copy2.Content = "فلز قلوي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "22.98976928";// الكتلة الذرية
            labelesm_Copy4.Content = "3s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "s";//المستوى الفرعي 
            labelesm_Copy6.Content = "1";//المجموعة
            labelesm_Copy7.Content = "3";//الدورة
            labelesm_Copy3.Content = "                       2, 8 , 1";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "Na.jpg", UriKind.Relative));

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)// bi
        {
            reader.SpeakAsync("Bismuth");
         
            labelesm.Content = "بزموت";//الاسم
            labelesm_Copy.Content = "83";//العدد
            labelesm_Copy1.Content = "Bi";//الرمز
            labelesm_Copy2.Content = " فلز بعد انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "208.98040 ";// الكتلة الذرية
            labelesm_Copy4.Content = "4f ^14  5d ^10  6s ^2  6p ^3";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "15";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "            2, 8, 18, 32, 18, 5";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "bi.jpg", UriKind.Relative));


        }

        private void Button_Click_6(object sender, RoutedEventArgs e)//Ca
        {
            reader.SpeakAsync("Calcium");
              
            labelesm.Content = "كالسيوم";//الاسم
            labelesm_Copy.Content = "20";//العدد
            labelesm_Copy1.Content = "Ca";//الرمز
            labelesm_Copy2.Content = " فلز قلوي ترابي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "40.078";// الكتلة الذرية
            labelesm_Copy4.Content = "4s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "s";//المستوى الفرعي 
            labelesm_Copy6.Content = "2";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "              2 , 8 , 8 , 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ca.jpg", UriKind.Relative));

        }

        private void Button_Click(object sender, RoutedEventArgs e)//K
        {
            reader.SpeakAsync("Potassium");
          
           
            labelesm.Content = "بوتاسيوم";//الاسم
            labelesm_Copy.Content = "19";//العدد
            labelesm_Copy1.Content = "K";//الرمز
            labelesm_Copy2.Content = "فلز قلوي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "39.0983";// الكتلة الذرية
            labelesm_Copy4.Content = "4s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "s";//المستوى الفرعي 
            labelesm_Copy6.Content = "1";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "           1 , 8 , 8 , 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "k.jpg", UriKind.Relative));


        }

        private void Button_Click_7(object sender, RoutedEventArgs e)//Sc
        {
            reader.SpeakAsync("Scandium");
     
            labelesm.Content = "سكانديوم";//الاسم
            labelesm_Copy.Content = "21";//العدد
            labelesm_Copy1.Content = "Sc";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "44.955912";// الكتلة الذرية
            labelesm_Copy4.Content = "3d^1 4s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "3";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "           2 , 9 , 8 , 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "sc.jpg", UriKind.Relative));

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)//Tc
        {
            reader.SpeakAsync("Technetium");
          
            labelesm.Content = "تكنيشيوم";//الاسم
            labelesm_Copy.Content = "43";//العدد
            labelesm_Copy1.Content = "Tc";//الرمز
            labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "98";// الكتلة الذرية
            labelesm_Copy4.Content = "4d^5 5s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "7";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "         2, 13, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)//Be
        {
            reader.SpeakAsync("Beryllium");
             labelesm.Content = "بيريليوم";//الاسم
            labelesm_Copy.Content = "4";//العدد
            labelesm_Copy1.Content = "Be";//الرمز
            labelesm_Copy2.Content = "فلز قلوي ترابي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "9.012182";// الكتلة الذرية
            labelesm_Copy4.Content = "1s^2 2s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "2";//المجموعة
            labelesm_Copy7.Content = "2";//الدورة
            labelesm_Copy3.Content = "                   2, 2  ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "be.jpg", UriKind.Relative));


        }

        private void Button_Click_10(object sender, RoutedEventArgs e)//Li
        {
            reader.SpeakAsync("Lithium");
          
            labelesm.Content = "ليثيوم";//الاسم
            labelesm_Copy.Content = "3";//العدد
            labelesm_Copy1.Content = "Li";//الرمز
            labelesm_Copy2.Content = "فلز قلوي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "6.941";// الكتلة الذرية
            labelesm_Copy4.Content = "1s^2 2s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "s";//المستوى الفرعي 
            labelesm_Copy6.Content = "1";//المجموعة
            labelesm_Copy7.Content = "2";//الدورة
            labelesm_Copy3.Content = "                   1 , 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "li.jpg", UriKind.Relative));

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)//Mg
        {
            reader.SpeakAsync("Magnesium");
         
            labelesm.Content = "مغنسيوم";//الاسم
            labelesm_Copy.Content = "12";//العدد
            labelesm_Copy1.Content = "Mg";//الرمز
            labelesm_Copy2.Content = " فلز قلوي ترابي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "24.3050";// الكتلة الذرية
            labelesm_Copy4.Content = " 3s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "s";//المستوى الفرعي 
            labelesm_Copy6.Content = "2";//المجموعة
            labelesm_Copy7.Content = "3";//الدورة
            labelesm_Copy3.Content = "                  2, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "mg.jpg", UriKind.Relative));


        }

        private void Button_Click_12(object sender, RoutedEventArgs e)//Rb
        {
            reader.SpeakAsync("Rubidium");
            labelesm.Content = "روبيديوم";//الاسم
            labelesm_Copy.Content = "37";//العدد
            labelesm_Copy1.Content = "Rb";//الرمز
            labelesm_Copy2.Content = "فلز قلوي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "85.4678";// الكتلة الذرية
            labelesm_Copy4.Content = "5s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "s";//المستوى الفرعي 
            labelesm_Copy6.Content = "1";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "         1, 8, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "rb.jpg", UriKind.Relative));


        }

        private void Button_Click_13(object sender, RoutedEventArgs e)//Sr
        {
            reader.SpeakAsync("Strontium");
             
            labelesm.Content = "سترونشيوم";//الاسم
            labelesm_Copy.Content = "38";//العدد
            labelesm_Copy1.Content = "Sr";//الرمز
            labelesm_Copy2.Content = "فلز قلوي ترابي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "88.90585";// الكتلة الذرية
            labelesm_Copy4.Content = "4d^1 5s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "3";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "       2, 9, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "sr.jpg", UriKind.Relative));

        }

        private void Button_Click_14(object sender, RoutedEventArgs e)//Cs
        {
            reader.SpeakAsync("Caesium");
             
            labelesm.Content = "سيزيوم";//الاسم
            labelesm_Copy.Content = "55";//العدد
            labelesm_Copy1.Content = "Cs";//الرمز
            labelesm_Copy2.Content = "فلز قلوي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "132.9054519";// الكتلة الذرية
            labelesm_Copy4.Content = " 6s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "s";//المستوى الفرعي 
            labelesm_Copy6.Content = "1";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "     1 , 8 , 18, 18, 8 , 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "cs.jpg", UriKind.Relative));

        }

        private void Button_Click_15(object sender, RoutedEventArgs e)//Ba
        {
            reader.SpeakAsync("Barium");
             
            labelesm.Content = "باريوم";//الاسم
            labelesm_Copy.Content = "56";//العدد
            labelesm_Copy1.Content = "Ba";//الرمز
            labelesm_Copy2.Content = "فلز قلوي ترابي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "137.33";// الكتلة الذرية
            labelesm_Copy4.Content = " 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "s";//المستوى الفرعي 
            labelesm_Copy6.Content = "2";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "      2 , 8 , 18, 18, 8 , 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ba.jpg", UriKind.Relative));


        }

        private void Button_Click_16(object sender, RoutedEventArgs e)//Fr
        {
            reader.SpeakAsync("Francium");
             
            labelesm.Content = "فرانسيوم";//الاسم
            labelesm_Copy.Content = "87";//العدد
            labelesm_Copy1.Content = "Fr";//الرمز
            labelesm_Copy2.Content = "فلز قلوي ";//تصنيف العنصر
            labelesm_Copy9.Content = "223";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = "7s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "s";//المستوى الفرعي 
            labelesm_Copy6.Content = "1";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "1 , 8, 18, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_17(object sender, RoutedEventArgs e)//Ra
        {
            reader.SpeakAsync("Radium");
           
            labelesm.Content = "راديوم";//الاسم
            labelesm_Copy.Content = "88";//العدد
            labelesm_Copy1.Content = "Ra";//الرمز
            labelesm_Copy2.Content = "فلز قلوي ترابي";//تصنيف العنصر
            labelesm_Copy9.Content = "226";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = "7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "s";//المستوى الفرعي 
            labelesm_Copy6.Content = "18";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "2 , 8, 18, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ra.jpg", UriKind.Relative));

        }

        private void Button_Click_18(object sender, RoutedEventArgs e)//Y
        {
            reader.SpeakAsync("Yttrium");
          
            labelesm.Content = "اتريوم";//الاسم
            labelesm_Copy.Content = "39";//العدد
            labelesm_Copy1.Content = "Y";//الرمز
            labelesm_Copy2.Content = " فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "88.90585";// الكتلة الذرية
            labelesm_Copy4.Content = "4d^1 5s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "3";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "      2, 9, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "y.jpg", UriKind.Relative));


        }

        private void Button_Click_19(object sender, RoutedEventArgs e)//Ti
        {
            reader.SpeakAsync("Titanium");
            labelesm.Content = "تيتانيوم";//الاسم
            labelesm_Copy.Content = "22";//العدد
            labelesm_Copy1.Content = "Ti";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "47.867";// الكتلة الذرية
            labelesm_Copy4.Content = "3d^2 4s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "4";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "           2 , 10 , 8 , 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ti.jpg", UriKind.Relative));

        }

        private void Button_Click_20(object sender, RoutedEventArgs e)//Zr
        {
            reader.SpeakAsync("Zirconium");
         
            labelesm.Content = "زركونيوم";//الاسم
            labelesm_Copy.Content = "40";//العدد
            labelesm_Copy1.Content = "Zr";//الرمز
            labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "91.224";// الكتلة الذرية
            labelesm_Copy4.Content = "5s^2 4d^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "4";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "            2, 10, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "zr.jpg", UriKind.Relative));

        }

        private void Button_Click_21(object sender, RoutedEventArgs e)//Hf
        {
            reader.SpeakAsync("Hafnium");
       
            labelesm.Content = "هافنيوم";//الاسم
            labelesm_Copy.Content = "72";//العدد
            labelesm_Copy1.Content = "Hf";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy9.Content = "178.49";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = "4f^14 5d^2 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "4";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "    2 , 10, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "hf.jpg", UriKind.Relative));


        }

        private void Button_Click_22(object sender, RoutedEventArgs e)//Rf
        {
            reader.SpeakAsync("Rutherfordium");
        
            labelesm.Content = "رذرفورديوم";//الاسم
            labelesm_Copy.Content = "104";//العدد
            labelesm_Copy1.Content = "Rf";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy9.Content = "261.11";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = " 5f^14 6d^2 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "4";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2 , 10, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_23(object sender, RoutedEventArgs e)//Db
        {
            reader.SpeakAsync("Dubnium");
              
            labelesm.Content = "دوبنيوم";//الاسم
            labelesm_Copy.Content = "105";//العدد
            labelesm_Copy1.Content = "Db";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "268";// الكتلة الذرية
            labelesm_Copy4.Content = "5f^14 6d^3 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "5";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2, 11, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_24(object sender, RoutedEventArgs e)//Ta
        {
            reader.SpeakAsync("Tantalum");
              
            labelesm.Content = "تانتالوم";//الاسم
            labelesm_Copy.Content = "73";//العدد
            labelesm_Copy1.Content = "Ta";//الرمز
            labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "180.94788";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^14 5d^3 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "5";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "     2, 11, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ta.jpg", UriKind.Relative));

        }

        private void Button_Click_25(object sender, RoutedEventArgs e)//Nb
        {
            reader.SpeakAsync("Niobium");
       
            
            labelesm.Content = "نيوبيوم";//الاسم
            labelesm_Copy.Content = "41";//العدد
            labelesm_Copy1.Content = "Nb";//الرمز
            labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "92.90638";// الكتلة الذرية
            labelesm_Copy4.Content = "4d^4 5s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "5";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "            1, 12, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nb.jpg", UriKind.Relative));

        }

        private void Button_Click_26(object sender, RoutedEventArgs e)//V
        {
            reader.SpeakAsync("Vanadium");
       
            labelesm.Content = "فاناديوم";//الاسم
            labelesm_Copy.Content = "23";//العدد
            labelesm_Copy1.Content = "V";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "50.9415";// الكتلة الذرية
            labelesm_Copy4.Content = "3d^3 4s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "5";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "              2 , 11 , 8 , 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "v.jpg", UriKind.Relative));


        }

        private void Button_Click_27(object sender, RoutedEventArgs e)//Cr
        {
            reader.SpeakAsync("Chromium");
              
            labelesm.Content = "كروم";//الاسم
            labelesm_Copy.Content = "24";//العدد
            labelesm_Copy1.Content = "Cr";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = " 51.9961";// الكتلة الذرية
            labelesm_Copy4.Content = "3d^5 4s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "6";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "                1 , 13 , 8 , 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "cr.jpg", UriKind.Relative));


        }

        private void Button_Click_28(object sender, RoutedEventArgs e)//Mo
        {
            reader.SpeakAsync("Molybdenum");
           
            labelesm.Content = "موليبدنوم";//الاسم
            labelesm_Copy.Content = "42";//العدد
            labelesm_Copy1.Content = "Mo";//الرمز
            labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "95.96";// الكتلة الذرية
            labelesm_Copy4.Content = "5s^1 4d^5";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "6";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "           1, 13, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "mo.jpg", UriKind.Relative));


        }

        private void Button_Click_29(object sender, RoutedEventArgs e)//W
        {
            reader.SpeakAsync("Tungsten");
           
            labelesm.Content = "تنغستن";//الاسم
            labelesm_Copy.Content = "74";//العدد
            labelesm_Copy1.Content = "W";//الرمز
            labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "183.84";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^14 5d^4 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "6";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "     2, 12, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "w.jpg", UriKind.Relative));

        }

        private void Button_Click_30(object sender, RoutedEventArgs e)//Sg
        {
            labelesm.Content = "سيبورغيوم";//الاسم
            labelesm_Copy.Content = "106";//العدد
            labelesm_Copy1.Content = "Sg";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "271";// الكتلة الذرية
            labelesm_Copy4.Content = "7s^2 5f^14 6d^4";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "7";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "2, 12, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_31(object sender, RoutedEventArgs e)//Bh
        {
            reader.SpeakAsync("Bohrium");
         
            labelesm.Content = "بوريوم";//الاسم
            labelesm_Copy.Content = "107";//العدد
            labelesm_Copy1.Content = "Bh";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "54.938045";// الكتلة الذرية
            labelesm_Copy4.Content = "4s^2 3d^5";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "7";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "2, 8, 18, 32, 32, 13, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_32(object sender, RoutedEventArgs e)//Re
        {
            reader.SpeakAsync("Rhenium");
           
            labelesm.Content = "رينيوم";//الاسم
            labelesm_Copy.Content = "75";//العدد
            labelesm_Copy1.Content = "Re";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "186.207";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^14 5d^5 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "6";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "    2 , 13 , 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "re.jpg", UriKind.Relative));

        }

        private void Button_Click_33(object sender, RoutedEventArgs e)//Mn
        {
            reader.SpeakAsync("Manganese");
          
            labelesm.Content = "منغنيز";//الاسم
            labelesm_Copy.Content = "25";//العدد
            labelesm_Copy1.Content = "Mn";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "54.938045";// الكتلة الذرية
            labelesm_Copy4.Content = "4s^2 3d^5";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "7";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "            2 , 13 , 8 , 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "mn.jpg", UriKind.Relative));

        }

        private void Button_Click_34(object sender, RoutedEventArgs e)//Fe
        {
            reader.SpeakAsync("Iron");
        
            labelesm.Content = "حديد";//الاسم
            labelesm_Copy.Content = "26";//العدد
            labelesm_Copy1.Content = "Fe";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "55.845";// الكتلة الذرية
            labelesm_Copy4.Content = "3d^6 4s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "8";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "               2 , 14 , 8 , 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "fe.jpg", UriKind.Relative));

        }

        private void Button_Click_35(object sender, RoutedEventArgs e)//Ru
        {
            reader.SpeakAsync("Ruthenium");
          
            labelesm.Content = "روثينيوم";//الاسم
            labelesm_Copy.Content = "44";//العدد
            labelesm_Copy1.Content = "Ru";//الرمز
            labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "101.07";// الكتلة الذرية
            labelesm_Copy4.Content = "4d^7 5s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "8";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "           1, 15, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ru.jpg", UriKind.Relative));

        }

        private void Button_Click_36(object sender, RoutedEventArgs e)//Os
        {
            reader.SpeakAsync("Osmium");
        
            labelesm.Content = "أوزميوم";//الاسم
            labelesm_Copy.Content = "76";//العدد
            labelesm_Copy1.Content = "Os";//الرمز
            labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "190.23";// الكتلة الذرية
            labelesm_Copy4.Content = " 4f^14 5d^6 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "8";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "     2, 14, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "os.jpg", UriKind.Relative));

        }

        private void Button_Click_37(object sender, RoutedEventArgs e)//Hs
        {
            reader.SpeakAsync("Hassium");
        
            labelesm.Content = "هاسيوم";//الاسم
            labelesm_Copy.Content = "108";//العدد
            labelesm_Copy1.Content = "Hs";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "269";// الكتلة الذرية
            labelesm_Copy4.Content = "5f^14 6d^6 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "8";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2 , 14 , 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_38(object sender, RoutedEventArgs e)//Mt
        {
            reader.SpeakAsync("Meitnerium");
       
            labelesm.Content = "مايتنريوم";//الاسم
            labelesm_Copy.Content = "109";//العدد
            labelesm_Copy1.Content = "Mt";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "278";// الكتلة الذرية
            labelesm_Copy4.Content = "7s^2 5f^14 6d^7";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "9";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2 , 15, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_39(object sender, RoutedEventArgs e)//Ir
        {
            reader.SpeakAsync("Iridium");
       
            labelesm.Content = "إريديوم";//الاسم
            labelesm_Copy.Content = "77";//العدد
            labelesm_Copy1.Content = "Ir";//الرمز
            labelesm_Copy2.Content = " فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "192.217";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^14 5d^7 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "9";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "     2, 15, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ir.jpg", UriKind.Relative));

        }

        private void Button_Click_40(object sender, RoutedEventArgs e)//Rh
        {
            reader.SpeakAsync("Rhodium");
       
            labelesm.Content = "روديوم";//الاسم
            labelesm_Copy.Content = "45";//العدد
            labelesm_Copy1.Content = "Rh";//الرمز
            labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "102.90550";// الكتلة الذرية
            labelesm_Copy4.Content = "5s^1 4d^8";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "9";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "              1, 16, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "rH.jpg", UriKind.Relative));

        }

        private void Button_Click_41(object sender, RoutedEventArgs e)//Co
        {
            reader.SpeakAsync("Cobalt");
       
            labelesm.Content = "كوبالت";//الاسم
            labelesm_Copy.Content = "27";//العدد
            labelesm_Copy1.Content = "Co";//الرمز
            labelesm_Copy2.Content = " فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "58.933195";// الكتلة الذرية
            labelesm_Copy4.Content = " 4s^2 3d^7";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "9";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "               2, 15 , 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "co.jpg", UriKind.Relative));

        }

        private void Button_Click_42(object sender, RoutedEventArgs e)//Ni
        {
            reader.SpeakAsync("Nickel");
         
            labelesm.Content = "نيكل";//الاسم
            labelesm_Copy.Content = "28";//العدد
            labelesm_Copy1.Content = "Ni";//الرمز
            labelesm_Copy2.Content = " فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "58.6934";// الكتلة الذرية
            labelesm_Copy4.Content = "4s^1 3d^9";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "10";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "               1, 17 , 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ni.jpg", UriKind.Relative));

        }

        private void Button_Click_43(object sender, RoutedEventArgs e)//Pd
        {
            reader.SpeakAsync("Palladium");
       
            labelesm.Content = "بالاديوم";//الاسم
            labelesm_Copy.Content = "46";//العدد
            labelesm_Copy1.Content = "Pd";//الرمز
            labelesm_Copy2.Content = "فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "106.42";// الكتلة الذرية
            labelesm_Copy4.Content = "4d^10 ";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "10";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "                18, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "pd.jpg", UriKind.Relative));

        }

        private void Button_Click_44(object sender, RoutedEventArgs e)//Pt
        {
            reader.SpeakAsync("Platinum");
          
            labelesm.Content = "بلاتين";//الاسم
            labelesm_Copy.Content = "78";//العدد
            labelesm_Copy1.Content = "Pt";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "195.084";// الكتلة الذرية
            labelesm_Copy4.Content = " 4f^14 5d^9 6s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "2";//المجموعة
            labelesm_Copy7.Content = "10";//الدورة
            labelesm_Copy3.Content = "       1, 17, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "pt.jpg", UriKind.Relative));

        }

        private void Button_Click_45(object sender, RoutedEventArgs e)//Ds
        {
            reader.SpeakAsync("Darmstadtium");
       
            labelesm.Content = "دارمشتاتيوم";//الاسم
            labelesm_Copy.Content = "110";//العدد
            labelesm_Copy1.Content = "Ds";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "281";// الكتلة الذرية
            labelesm_Copy4.Content = "7s^1 5f^14 6d^9";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "2";//المجموعة
            labelesm_Copy7.Content = "10";//الدورة
            labelesm_Copy3.Content = "1, 17, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));


        }

        private void Button_Click_46(object sender, RoutedEventArgs e)//Rg
        {
            reader.SpeakAsync("Roentgenium");
              
            labelesm.Content = "رونتجينيوم";//الاسم
            labelesm_Copy.Content = "111";//العدد
            labelesm_Copy1.Content = "Rg";//الرمز
            labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "101.07";// الكتلة الذرية
            labelesm_Copy4.Content = " 5f^14 6d^10 7s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "11";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "1, 18, 32 , 32, 18 ,8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_47(object sender, RoutedEventArgs e)//Au
        {
            reader.SpeakAsync("Gold");
              
            labelesm.Content = "الذهب";//الاسم
            labelesm_Copy.Content = "79";//العدد
            labelesm_Copy1.Content = "Au";//الرمز
            labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "196.966569";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^14 5d^10 6s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "8";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "     1, 18, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "au.jpg", UriKind.Relative));

        }

        private void Button_Click_48(object sender, RoutedEventArgs e)//Ag
        {
            reader.SpeakAsync("Silver");
       
            labelesm.Content = "فضة";//الاسم
            labelesm_Copy.Content = "47";//العدد
            labelesm_Copy1.Content = "Ag";//الرمز
            labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "107.8682";// الكتلة الذرية
            labelesm_Copy4.Content = "4d^10 5s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "11";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "             1, 18, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ag.jpg", UriKind.Relative));

        }

        private void Button_Click_49(object sender, RoutedEventArgs e)//Cu
        {
            reader.SpeakAsync("Copper");
       
            labelesm.Content = "نحاس";//الاسم
            labelesm_Copy.Content = "29";//العدد
            labelesm_Copy1.Content = "Cu";//الرمز
            labelesm_Copy2.Content = " فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "63.546";// الكتلة الذرية
            labelesm_Copy4.Content = "3d^10 4s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "11";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "               1, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "cu.jpg", UriKind.Relative));


        }

        private void Button_Click_50(object sender, RoutedEventArgs e)//Zn
        {
            reader.SpeakAsync("Zinc");
       
            labelesm.Content = "زنك";//الاسم
            labelesm_Copy.Content = "30";//العدد
            labelesm_Copy1.Content = "Zn";//الرمز
            labelesm_Copy2.Content = " فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "65.38";// الكتلة الذرية
            labelesm_Copy4.Content = "3d^10 4s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "12";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "              2, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "zn.jpg", UriKind.Relative));


        }

        private void Button_Click_51(object sender, RoutedEventArgs e)//Cd
        {
            reader.SpeakAsync("Cadmium");
            labelesm.Content = "كادميوم";//الاسم
            labelesm_Copy.Content = "48";//العدد
            labelesm_Copy1.Content = "Cd";//الرمز
            labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "112.411";// الكتلة الذرية
            labelesm_Copy4.Content = " 5s^2 4d^10";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "12";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "            2, 18, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "cd.jpg", UriKind.Relative));

        }

        private void Button_Click_52(object sender, RoutedEventArgs e)//Hg
        {
            reader.SpeakAsync("Mercury ");
            labelesm.Content = "زئبق";//الاسم
            labelesm_Copy.Content = "80";//العدد
            labelesm_Copy1.Content = "Hg";//الرمز
            labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "200.59";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^14 5d^10 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "12";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "     2, 18, 32, 18 , 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "hg.jpg", UriKind.Relative));

        }

        private void Button_Click_53(object sender, RoutedEventArgs e)//Cn
        {
            reader.SpeakAsync("Copernicium");
              
            labelesm.Content = "كوبرنيسيوم";//الاسم
            labelesm_Copy.Content = "112";//العدد
            labelesm_Copy1.Content = "Cn";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "285";// الكتلة الذرية
            labelesm_Copy4.Content = "5f^14 6d^10 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "12";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2 , 18, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_54(object sender, RoutedEventArgs e)//He
        {
            reader.SpeakAsync("Helium");
          
            labelesm.Content = "هيليوم";//الاسم
            labelesm_Copy.Content = "2";//العدد
            labelesm_Copy1.Content = "He";//الرمز
            labelesm_Copy2.Content = "غاز نبيل";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "4.002602";// الكتلة الذرية
            labelesm_Copy4.Content = "1s^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "s";//المستوى الفرعي 
            labelesm_Copy6.Content = "18";//المجموعة
            labelesm_Copy7.Content = "1";//الدورة
            labelesm_Copy3.Content = "                  2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "he.jpg", UriKind.Relative));

        }

        private void Button_Click_55(object sender, RoutedEventArgs e)//B
        {
            reader.SpeakAsync("Boron");
           
            labelesm.Content = "بورون";//الاسم
            labelesm_Copy.Content = "5";//العدد
            labelesm_Copy1.Content = "B";//الرمز
            labelesm_Copy2.Content = "شبه فلز";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "10.811";// الكتلة الذرية
            labelesm_Copy4.Content = " 2s^2 2p^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = " p";//المستوى الفرعي 
            labelesm_Copy6.Content = "13";//المجموعة
            labelesm_Copy7.Content = "2";//الدورة
            labelesm_Copy3.Content = "               3 ,2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "b.jpg", UriKind.Relative));


        }

        private void Button_Click_56(object sender, RoutedEventArgs e)//C
        {
            reader.SpeakAsync("Carbon");
            labelesm.Content = "كربون";//الاسم
            labelesm_Copy.Content = "6";//العدد
            labelesm_Copy1.Content = "C";//الرمز
            labelesm_Copy2.Content = "لا فلز";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "12.0107";// الكتلة الذرية
            labelesm_Copy4.Content = "2s^2 2p^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "14";//المجموعة
            labelesm_Copy7.Content = "2";//الدورة
            labelesm_Copy3.Content = "               2, 4";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "c.jpg", UriKind.Relative));


        }

        private void Button_Click_57(object sender, RoutedEventArgs e)//N
        {
            reader.SpeakAsync("Nitrogen");
        
            labelesm.Content = "نيتروجين";//الاسم
            labelesm_Copy.Content = "7";//العدد
            labelesm_Copy1.Content = "N";//الرمز
            labelesm_Copy2.Content = "لا فلز";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "14.0067";// الكتلة الذرية
            labelesm_Copy4.Content = "1s^2 2s^2 2p^3";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "15";//المجموعة
            labelesm_Copy7.Content = "2";//الدورة
            labelesm_Copy3.Content = "                5, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "N.jpg", UriKind.Relative));

        }

        private void Button_Click_58(object sender, RoutedEventArgs e)//O
        {
            reader.SpeakAsync("Oxygen");
         
            labelesm.Content = "أكسجين";//الاسم
            labelesm_Copy.Content = "8";//العدد
            labelesm_Copy1.Content = "O";//الرمز
            labelesm_Copy2.Content = "لا فلز, كالكوجين";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "15.9994";// الكتلة الذرية
            labelesm_Copy4.Content = "1s^2 2s^2 2p^4";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "16";//المجموعة
            labelesm_Copy7.Content = "2";//الدورة
            labelesm_Copy3.Content = "                 6, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "o.jpg", UriKind.Relative));

        }

        private void Button_Click_59(object sender, RoutedEventArgs e)//F
        {
            reader.SpeakAsync("Fluorine");
       
            labelesm.Content = "فلور";//الاسم
            labelesm_Copy.Content = "9";//العدد
            labelesm_Copy1.Content = "F";//الرمز
            labelesm_Copy2.Content = "هالوجين";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "18.9984032";// الكتلة الذرية
            labelesm_Copy4.Content = "1s^2 2s^2 2p^5";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "17";//المجموعة
            labelesm_Copy7.Content = "2";//الدورة
            labelesm_Copy3.Content = "               7, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "f.jpg", UriKind.Relative));

        }

        private void Button_Click_60(object sender, RoutedEventArgs e)//Ne
        {
            reader.SpeakAsync("Neon");
       
            labelesm.Content = "نيون";//الاسم
            labelesm_Copy.Content = "10";//العدد
            labelesm_Copy1.Content = "Ne";//الرمز
            labelesm_Copy2.Content = "غاز نبيل";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "20.1797";// الكتلة الذرية
            labelesm_Copy4.Content = "1s^2 2s^2 2p^6";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "18";//المجموعة
            labelesm_Copy7.Content = "2";//الدورة
            labelesm_Copy3.Content = "               8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "Ne.jpg", UriKind.Relative));

        }

        private void Button_Click_61(object sender, RoutedEventArgs e)//Al
        {
            reader.SpeakAsync("Aluminium");
           
            labelesm.Content = "ألومنيوم";//الاسم
            labelesm_Copy.Content = "13";//العدد
            labelesm_Copy1.Content = "Al";//الرمز
            labelesm_Copy2.Content = "فلز آخر";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "26.9815386";// الكتلة الذرية
            labelesm_Copy4.Content = " 3s^2 3p^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "13";//المجموعة
            labelesm_Copy7.Content = "3";//الدورة
            labelesm_Copy3.Content = "                3, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "al.jpg", UriKind.Relative));

        }

        private void Button_Click_62(object sender, RoutedEventArgs e)//Si
        {
            reader.SpeakAsync("Silicon");
        
            labelesm.Content = "سليكون";//الاسم
            labelesm_Copy.Content = "14";//العدد
            labelesm_Copy1.Content = "Si";//الرمز
            labelesm_Copy2.Content = "شبه فلز";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "28.0855";// الكتلة الذرية
            labelesm_Copy4.Content = "  3s^2 3p^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "14";//المجموعة
            labelesm_Copy7.Content = "3";//الدورة
            labelesm_Copy3.Content = "                4, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "si.jpg", UriKind.Relative));

        }

        private void Button_Click_63(object sender, RoutedEventArgs e)//P
        {
            reader.SpeakAsync("Phosphorus");
       
            labelesm.Content = "فسفور";//الاسم
            labelesm_Copy.Content = "15";//العدد
            labelesm_Copy1.Content = "P";//الرمز
            labelesm_Copy2.Content = "لا فلز";//تصنيف العنصر
            labelesm_Copy9.Content = "30.973762";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = "3s^2 3p^3";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "15";//المجموعة
            labelesm_Copy7.Content = "3";//الدورة
            labelesm_Copy3.Content = "               5, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "p.jpg", UriKind.Relative));

        }

        private void Button_Click_64(object sender, RoutedEventArgs e)//S
        {
            reader.SpeakAsync("Sulfur");
          
            labelesm.Content = "كبريت";//الاسم
            labelesm_Copy.Content = "16";//العدد
            labelesm_Copy1.Content = "S";//الرمز
            labelesm_Copy2.Content = "لا فلز";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "32.065";// الكتلة الذرية
            labelesm_Copy4.Content = "3s^2 3p^4";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "16";//المجموعة
            labelesm_Copy7.Content = "3";//الدورة
            labelesm_Copy3.Content = "                6, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "s.jpg", UriKind.Relative));

        }

        private void Button_Click_65(object sender, RoutedEventArgs e)//Cl
        {
            reader.SpeakAsync("Chlorine");
        
            labelesm.Content = "كلور";//الاسم
            labelesm_Copy.Content = "17";//العدد
            labelesm_Copy1.Content = "Cl";//الرمز
            labelesm_Copy2.Content = "هالوجين";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "35.453";// الكتلة الذرية
            labelesm_Copy4.Content = "3s^2 3p^5";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "17";//المجموعة
            labelesm_Copy7.Content = "3";//الدورة
            labelesm_Copy3.Content = "                7, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "cl.jpg", UriKind.Relative));

        }

        private void Button_Click_66(object sender, RoutedEventArgs e)//Ar
        {
            reader.SpeakAsync("Argon");
          
            labelesm.Content = "أرغون";//الاسم
            labelesm_Copy.Content = "18";//العدد
            labelesm_Copy1.Content = "Ar";//الرمز
            labelesm_Copy2.Content = " غاز نبيل";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "39.948";// الكتلة الذرية
            labelesm_Copy4.Content = "3s^2 3p^6";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "18";//المجموعة
            labelesm_Copy7.Content = "3";//الدورة
            labelesm_Copy3.Content = "                8, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ar.jpg", UriKind.Relative));

        }

        private void Button_Click_67(object sender, RoutedEventArgs e)//Ga
        {
            reader.SpeakAsync("Gallium");
        
            labelesm.Content = "غاليوم";//الاسم
            labelesm_Copy.Content = "31";//العدد
            labelesm_Copy1.Content = "Ga";//الرمز
            labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "69.723";// الكتلة الذرية
            labelesm_Copy4.Content = " 4s^2 3d^10 4p^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "13";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "               3, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ga.jpg", UriKind.Relative));


        }

        private void Button_Click_68(object sender, RoutedEventArgs e)//Ge
        {
            reader.SpeakAsync("Germanium");
        
            labelesm.Content = "جرمانيوم";//الاسم
            labelesm_Copy.Content = "32";//العدد
            labelesm_Copy1.Content = "Ge";//الرمز
            labelesm_Copy2.Content = "شبه فلز";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "72.64";// الكتلة الذرية
            labelesm_Copy4.Content = " 3d^10 4s^2 4p^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "14";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "               4, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ge.jpg", UriKind.Relative));


        }

        private void Button_Click_69(object sender, RoutedEventArgs e)//As
        {
            reader.SpeakAsync("Arsenic");
          
            labelesm.Content = "زرنيخ";//الاسم
            labelesm_Copy.Content = "33";//العدد
            labelesm_Copy1.Content = "As";//الرمز
            labelesm_Copy2.Content = "شبه فلز";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "74.92160";// الكتلة الذرية
            labelesm_Copy4.Content = "4s^2 3d^10 4p^3";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "15";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "               5, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "as.jpg", UriKind.Relative));


        }


        private void Button_Click_71(object sender, RoutedEventArgs e)//Br
        {
            reader.SpeakAsync("Bromine");
       
            labelesm.Content = "بروم";//الاسم
            labelesm_Copy.Content = "35";//العدد
            labelesm_Copy1.Content = "Br";//الرمز
            labelesm_Copy2.Content = "هالوجين";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "79.904";// الكتلة الذرية
            labelesm_Copy4.Content = "4s^2 3d^10 4p^5";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "17";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "                7, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "br.jpg", UriKind.Relative));

        }

        private void Button_Click_72(object sender, RoutedEventArgs e)//Kr
        {
            reader.SpeakAsync("Krypton");
       
            labelesm.Content = "كريبتون";//الاسم
            labelesm_Copy.Content = "36";//العدد
            labelesm_Copy1.Content = "Kr";//الرمز
            labelesm_Copy2.Content = "غاز نبيل";//تصنيف العنصر
            labelesm_Copy9.Content = "83.798";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = "3d^10 4s^2 4p^6";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "18";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "                8, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "kr.jpg", UriKind.Relative));

        }

        private void Button_Click_73(object sender, RoutedEventArgs e)//In
        {
            reader.SpeakAsync("Indium");
         
            labelesm.Content = "إنديوم";//الاسم
            labelesm_Copy.Content = "49";//العدد
            labelesm_Copy1.Content = "In";//الرمز
            labelesm_Copy2.Content = " فلز بعد انتقالي";//تصنيف العنصر
            labelesm_Copy9.Content = "114.818";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = "4d^10 5s^2 5p^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "13";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "              3, 18, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "in.jpg", UriKind.Relative));


        }

        private void Button_Click_74(object sender, RoutedEventArgs e)//Sn
        {
            reader.SpeakAsync("Tin");
            
            labelesm.Content = "قصدير";//الاسم
            labelesm_Copy.Content = "50";//العدد
            labelesm_Copy1.Content = "Sn";//الرمز
            labelesm_Copy2.Content = " فلز بعد انتقالي";//تصنيف العنصر
            labelesm_Copy9.Content = "118.710";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = "4d^10 5s^2 5p^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "14";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "               4, 18, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "sn.jpg", UriKind.Relative));

        }

        private void Button_Click_75(object sender, RoutedEventArgs e)//Sb
        {
            reader.SpeakAsync("Antimony");
       
            labelesm.Content = "اثمد";//الاسم
            labelesm_Copy.Content = "51";//العدد
            labelesm_Copy1.Content = "Sb";//الرمز
            labelesm_Copy2.Content = " شبه فلز";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "121.760";// الكتلة الذرية
            labelesm_Copy4.Content = "4d^10 5s^2 5p^3";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "15";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "               5, 18, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "sb.jpg", UriKind.Relative));

        }

        private void Button_Click_76(object sender, RoutedEventArgs e)//Te
        {
            reader.SpeakAsync("Tellurium");
       
            labelesm.Content = "تيلوريوم";//الاسم
            labelesm_Copy.Content = "52";//العدد
            labelesm_Copy1.Content = "Te";//الرمز
            labelesm_Copy2.Content = "شبه فلز";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "127.60";// الكتلة الذرية
            labelesm_Copy4.Content = " 4d^10 5s^2 5p^4";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "16";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "              6, 18, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "te.jpg", UriKind.Relative));

        }

        private void Button_Click_77(object sender, RoutedEventArgs e)//I
        {
            reader.SpeakAsync("Iodine");
         
            labelesm.Content = "يود";//الاسم
            labelesm_Copy.Content = "53";//العدد
            labelesm_Copy1.Content = "I";//الرمز
            labelesm_Copy2.Content = "هالوجين";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "126.90447";// الكتلة الذرية
            labelesm_Copy4.Content = " 4d^10 5s^2 5p^5";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "17";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "     7, 18, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "i.jpg", UriKind.Relative));

        }

        private void Button_Click_78(object sender, RoutedEventArgs e)//Xe
        {
            reader.SpeakAsync("Xenon");
         
            labelesm.Content = "زينون";//الاسم
            labelesm_Copy.Content = "54";//العدد
            labelesm_Copy1.Content = "Xe";//الرمز
            labelesm_Copy2.Content = "غاز نبيل";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "131.293";// الكتلة الذرية
            labelesm_Copy4.Content = "5s^2 4d^10 5p^6";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "18";//المجموعة
            labelesm_Copy7.Content = "5";//الدورة
            labelesm_Copy3.Content = "         8, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "xe.jpg", UriKind.Relative));

        }

        private void Button_Click_79(object sender, RoutedEventArgs e)//Ti
        {
            reader.SpeakAsync("Thallium");
        
            labelesm.Content = "ثاليوم";//الاسم
            labelesm_Copy.Content = "81";//العدد
            labelesm_Copy1.Content = "Tl";//الرمز
            labelesm_Copy2.Content = "فلز بعد انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "204.3833";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^14 5d^10 6s^2 6p^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "13";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "     3, 18 , 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ti.jpg", UriKind.Relative));

        }

        private void Button_Click_80(object sender, RoutedEventArgs e)//Pb
        {
            reader.SpeakAsync("Lead");
        
            labelesm.Content = "رصاص";//الاسم
            labelesm_Copy.Content = "82";//العدد
            labelesm_Copy1.Content = "Pb";//الرمز
            labelesm_Copy2.Content = "فلز بعد انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "207.2";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^14 5d^10 6s^2 6p^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "14";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "      4, 18 , 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "pb.jpg", UriKind.Relative));

        }

        private void Button_Click_81(object sender, RoutedEventArgs e)//Bi
        {
            labelesm.Content = "بزموت";//الاسم
            labelesm_Copy.Content = "83";//العدد
            labelesm_Copy1.Content = "Bi";//الرمز
            labelesm_Copy2.Content = " فلز بعد انتقالي";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "208.98040";// الكتلة الذرية
            labelesm_Copy4.Content = "4f ^14  5d ^10  6s ^2  6p ^3";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "15";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "      2, 8, 18, 32, 18, 5";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "bi.jpg", UriKind.Relative));

        }

        private void Button_Click_82(object sender, RoutedEventArgs e)//Po
        {
            reader.SpeakAsync("Polonium");
           
            labelesm.Content = "بولونيوم";//الاسم
            labelesm_Copy.Content = "84";//العدد
            labelesm_Copy1.Content = "Po";//الرمز
            labelesm_Copy2.Content = "شبه فلز";//تصنيف العنصر
            labelesm_Copy9.Content = "209";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = " 6s^2 4f^14 5d^10 6p^4";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "16";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "      6, 18, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_83(object sender, RoutedEventArgs e)//At
        {
            reader.SpeakAsync("Astatine");
        
            labelesm.Content = "أستاتين";//الاسم
            labelesm_Copy.Content = "85";//العدد
            labelesm_Copy1.Content = "At";//الرمز
            labelesm_Copy2.Content = " شبه فلز";//تصنيف العنصر
            labelesm_Copy9.Content = "210";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = "4f^14 5d^10 6s^2 6p^5";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "17";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "     7, 18, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_84(object sender, RoutedEventArgs e)//Rn
        {
            reader.SpeakAsync("Radon");
       
            labelesm.Content = "رادون";//الاسم
            labelesm_Copy.Content = "86";//العدد
            labelesm_Copy1.Content = "Rn";//الرمز
            labelesm_Copy2.Content = "غاز نبيل";//تصنيف العنصر
            labelesm_Copy9.Content = "222";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = "4f^14 5d^10 6s^2 6p^6";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "18";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "    8, 18, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_85(object sender, RoutedEventArgs e)//Uut
        {
            reader.SpeakAsync("Ununtrium");
           
            labelesm.Content = "أنون تريوم";//الاسم
            labelesm_Copy.Content = "113";//العدد
            labelesm_Copy1.Content = "Uut";//الرمز
            labelesm_Copy2.Content = "افتراضيا فلز ضعيف";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "286";// الكتلة الذرية
            labelesm_Copy4.Content = "5f^14 6d^10 7s^2 7p^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "13";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "3 , 18, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_86(object sender, RoutedEventArgs e)//Uuq
        {
            reader.SpeakAsync("Flerovium");
           
            labelesm.Content = "فليروفيوم";//الاسم
            labelesm_Copy.Content = "114";//العدد
            labelesm_Copy1.Content = "Fl";//الرمز
            labelesm_Copy2.Content = "غير معروف";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "289";// الكتلة الذرية
            labelesm_Copy4.Content = "5f^14 6d^10 7s^2 7p^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "14";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "4 , 18, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_87(object sender, RoutedEventArgs e)//Uup
        {
            reader.SpeakAsync("Ununpentium");
       
            labelesm.Content = "أنون بنتيوم";//الاسم
            labelesm_Copy.Content = "115";//العدد
            labelesm_Copy1.Content = "Uup";//الرمز
            labelesm_Copy2.Content = "غير معروف";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "289";// الكتلة الذرية
            labelesm_Copy4.Content = "5f^14 6d^10 7s^2 7p^3";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "15";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "5 , 18, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_88(object sender, RoutedEventArgs e)//lv
        {
            reader.SpeakAsync("Livermorium");
       
            labelesm.Content = "ليفرموريوم";//الاسم
            labelesm_Copy.Content = "116";//العدد
            labelesm_Copy1.Content = "Lv";//الرمز
            labelesm_Copy2.Content = "غير معروف";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "293";// الكتلة الذرية
            labelesm_Copy4.Content = "5f^14 6d^10 7s^2 7p^4";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "16";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "6 , 18, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 

        }

        private void Button_Click_100(object sender, RoutedEventArgs e)//Se
        {
            reader.SpeakAsync("Selenium");
       
            labelesm.Content = "سيلينيوم";//الاسم
            labelesm_Copy.Content = "34";//العدد
            labelesm_Copy1.Content = "Se";//الرمز
            labelesm_Copy2.Content = "لا فلز";//تصنيف العنصر
            labelesm_Copy9.Content = "78.96";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = " 4s^2 3d^10 4p^4";//توزيع الالكتروني 
            labelesm_Copy5.Content = "p";//المستوى الفرعي 
            labelesm_Copy6.Content = "16";//المجموعة
            labelesm_Copy7.Content = "4";//الدورة
            labelesm_Copy3.Content = "                6, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "se.jpg", UriKind.Relative));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//La
        {
            reader.SpeakAsync("Lanthanum");
             
            labelesm.Content = "لانثانوم";//الاسم
            labelesm_Copy.Content = "57";//العدد
            labelesm_Copy1.Content = "La";//الرمز
            labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "138.90547";// الكتلة الذرية
            labelesm_Copy4.Content = "5d^1 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "     2 , 9, 18, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "la.jpg", UriKind.Relative));

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//bk
        {
            reader.SpeakAsync("Berkelium");
       
            labelesm.Content = "بركيليوم";//الاسم
            labelesm_Copy.Content = "97";//العدد
            labelesm_Copy1.Content = "Bk";//الرمز
            labelesm_Copy2.Content = "أكتينيدات";//تصنيف العنصر
            labelesm_Copy9.Content = "247";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = "5f^9 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2, 8, 27, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_89(object sender, RoutedEventArgs e)//pa
        {
            reader.SpeakAsync("Protactinium");
           
            labelesm.Content = "بروتكتينيوم";//الاسم
            labelesm_Copy.Content = "91";//العدد
            labelesm_Copy1.Content = "Pa";//الرمز
            labelesm_Copy2.Content = "أكتينيدات";//تصنيف العنصر
            labelesm_Copy9.Content = "231.03588";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = " 7s^2 6d^1 5f^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2, 9, 20, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_90(object sender, RoutedEventArgs e)//pu
        {
            reader.SpeakAsync("Plutonium");
          
            labelesm.Content = "بلوتونيوم";//الاسم
            labelesm_Copy.Content = "94";//العدد
            labelesm_Copy1.Content = "Pu";//الرمز
            labelesm_Copy2.Content = "أكتينيدات";//تصنيف العنصر
            labelesm_Copy9.Content = "244";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = "5f^6 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2, 8, 24, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "pu.jpg", UriKind.Relative));

        }

        private void Button_Click_91(object sender, RoutedEventArgs e)//lu
        {
            reader.SpeakAsync("Lutetium");
     
            labelesm.Content = "لوتيشيوم";//الاسم
            labelesm_Copy.Content = "71";//العدد
            labelesm_Copy1.Content = "Lu";//الرمز
            labelesm_Copy2.Content = "أكتينيدات";//تصنيف العنصر
            labelesm_Copy9.Content = "174.9668";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = " 6s^2 4f^14 5d^1";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "    2, 9, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "lu.jpg", UriKind.Relative));

        }

        private void Button_Click_92(object sender, RoutedEventArgs e)//tb
        {
            reader.SpeakAsync("Terbium");
          
            labelesm.Content = "تيربيوم";//الاسم
            labelesm_Copy.Content = "65";//العدد
            labelesm_Copy1.Content = "Tb";//الرمز
            labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
            labelesm_Copy9.Content = "158.92535";// الكتلة الذرية
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy4.Content = " 4f^9 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "    2, 8, 27, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "tb.jpg", UriKind.Relative));

        }

        private void Button_Click_93(object sender, RoutedEventArgs e)//th
        {
            reader.SpeakAsync("Thorium");
            
            labelesm.Content = "ثوريوم";//الاسم
            labelesm_Copy.Content = "90";//العدد
            labelesm_Copy1.Content = "Th";//الرمز
            labelesm_Copy2.Content = "أكتينيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "232.0381";// الكتلة الذرية
            labelesm_Copy4.Content = "6d^2 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2, 10, 18, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_94(object sender, RoutedEventArgs e)//tm
        {
            reader.SpeakAsync("Thulium");
     
            labelesm.Content = "ثوليوم";//الاسم
            labelesm_Copy.Content = "69";//العدد
            labelesm_Copy1.Content = "Tm";//الرمز
            labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "168.93421";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^13 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "    2, 8, 31, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "tm.jpg", UriKind.Relative));

        }

        private void Button_Click_95(object sender, RoutedEventArgs e)//er
        {
            reader.SpeakAsync("Erbium");
         
            labelesm.Content = "إربيوم";//الاسم
            labelesm_Copy.Content = "68";//العدد
            labelesm_Copy1.Content = "Er";//الرمز
            labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "167.259";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^12 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "     2 , 8, 30, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "er.jpg", UriKind.Relative));

        }

        private void Button_Click_96(object sender, RoutedEventArgs e)//sm
        {
            reader.SpeakAsync("Samarium");
               
            labelesm.Content = "ساماريوم";//الاسم
            labelesm_Copy.Content = "62";//العدد
            labelesm_Copy1.Content = "Sm";//الرمز
            labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "150.36";// الكتلة الذرية
            labelesm_Copy4.Content = " 6s^2 4f^6";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "     2, 8, 24, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "sm.jpg", UriKind.Relative));

        }

        private void Button_Click_97(object sender, RoutedEventArgs e)
        {
            labelesm.Content = "3";//الاسم
            labelesm_Copy.Content = "";//العدد
            labelesm_Copy1.Content = "";//الرمز
            labelesm_Copy2.Content = "";//تصنيف العنصر
            labelesm_Copy8.Content = "";
            labelesm_Copy9.Content = "";// الكتلة الذرية
            labelesm_Copy4.Content = "";//توزيع الالكتروني 
            labelesm_Copy5.Content = "";//المستوى الفرعي 
            labelesm_Copy6.Content = "";//المجموعة
            labelesm_Copy7.Content = "";//الدورة
            labelesm_Copy3.Content = "";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_98(object sender, RoutedEventArgs e)//eu
        {
            reader.SpeakAsync("Europium");
         
            labelesm.Content = "يوروبيوم";//الاسم
            labelesm_Copy.Content = "63";//العدد
            labelesm_Copy1.Content = "Eu";//الرمز
            labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "151.964";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^7 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "    2, 8, 25, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_99(object sender, RoutedEventArgs e)//ho
        {
            reader.SpeakAsync("Holmium");
     
            labelesm.Content = "هولميوم";//الاسم
            labelesm_Copy.Content = "67";//العدد
            labelesm_Copy1.Content = "Ho";//الرمز
            labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "164.93032";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^7 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "       2, 8, 29, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ho.jpg", UriKind.Relative));


        }

        private void Button_Click_101(object sender, RoutedEventArgs e)//lr
        {
            reader.SpeakAsync("Lawrencium");
           
            labelesm.Content = "لورنسيوم";//الاسم
            labelesm_Copy.Content = "103";//العدد
            labelesm_Copy1.Content = "Lr";//الرمز
            labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "262";// الكتلة الذرية
            labelesm_Copy4.Content = " 5f^14 6d^1 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "d";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2 , 9, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_102(object sender, RoutedEventArgs e)//no
        {
            reader.SpeakAsync("Nobelium");
     
            labelesm.Content = "نوبليوم";//الاسم
            labelesm_Copy.Content = "102";//العدد
            labelesm_Copy1.Content = "No";//الرمز
            labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "259";// الكتلة الذرية
            labelesm_Copy4.Content = "5f^14 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2 , 8, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_103(object sender, RoutedEventArgs e)//md
        {
            reader.SpeakAsync("Mendelevium");
         
            labelesm.Content = "مندليفيوم";//الاسم
            labelesm_Copy.Content = "101";//العدد
            labelesm_Copy1.Content = "Md";//الرمز
            labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "258";// الكتلة الذرية
            labelesm_Copy4.Content = "5f^13 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2 , 8, 31, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_104(object sender, RoutedEventArgs e)//fm
        {
            reader.SpeakAsync("Fermium");
     
            labelesm.Content = "فرميوم";//الاسم
            labelesm_Copy.Content = "100";//العدد
            labelesm_Copy1.Content = "Fm";//الرمز
            labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "257";// الكتلة الذرية
            labelesm_Copy4.Content = "5f^12 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2 , 8, 30, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_105(object sender, RoutedEventArgs e)//es
        {
            reader.SpeakAsync("Einsteinium");
       
            labelesm.Content = "أينشتاينيوم";//الاسم
            labelesm_Copy.Content = "99";//العدد
            labelesm_Copy1.Content = "Es";//الرمز
            labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "252";// الكتلة الذرية
            labelesm_Copy4.Content = "5f^11 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2 , 8, 29, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_106(object sender, RoutedEventArgs e)//cf
        {
            reader.SpeakAsync("Californium");
      
            labelesm.Content = "كاليفورنيوم";//الاسم
            labelesm_Copy.Content = "98";//العدد
            labelesm_Copy1.Content = "Cf";//الرمز
            labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "251";// الكتلة الذرية
            labelesm_Copy4.Content = "5f^10 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "   2 , 8, 28, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_107(object sender, RoutedEventArgs e)//cm
        {

            reader.SpeakAsync("Curium");
        
            labelesm.Content = "كوريوم";//الاسم
            labelesm_Copy.Content = "96";//العدد
            labelesm_Copy1.Content = "Cm";//الرمز
            labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "247";// الكتلة الذرية
            labelesm_Copy4.Content = "5f^7 6d^1 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2 , 8, 25, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_108(object sender, RoutedEventArgs e)//am
        {
            reader.SpeakAsync("Americium");
        
            labelesm.Content = "أمريسيوم";//الاسم
            labelesm_Copy.Content = "95";//العدد
            labelesm_Copy1.Content = "Am";//الرمز
            labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "243";// الكتلة الذرية
            labelesm_Copy4.Content = " 5f^7 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2 , 8, 25, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "am.jpg", UriKind.Relative));

        }

        private void Button_Click_109(object sender, RoutedEventArgs e)//np
        {
            reader.SpeakAsync("Neptunium");
           
            labelesm.Content = "نبتونيوم";//الاسم
            labelesm_Copy.Content = "93";//العدد
            labelesm_Copy1.Content = "Np";//الرمز
            labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "237";// الكتلة الذرية
            labelesm_Copy4.Content = "7s^2 6d^1 5f^4";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2 , 9, 22, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "np.jpg", UriKind.Relative));

        }

        private void Button_Click_110(object sender, RoutedEventArgs e)//u
        {
            reader.SpeakAsync("Uranium");
          
            labelesm.Content = "يورانيوم";//الاسم
            labelesm_Copy.Content = "92";//العدد
            labelesm_Copy1.Content = "U";//الرمز
            labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "238.02891";// الكتلة الذرية
            labelesm_Copy4.Content = " 5f^3 6d^1 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "2 , 9, 21, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "u.jpg", UriKind.Relative));

        }

        private void Button_Click_111(object sender, RoutedEventArgs e)//ac
        {
            reader.SpeakAsync("Actinium");
             
            labelesm.Content = "أكتينيوم";//الاسم
            labelesm_Copy.Content = "89";//العدد
            labelesm_Copy1.Content = "Ac";//الرمز
            labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "227";// الكتلة الذرية
            labelesm_Copy4.Content = "6d^1 7s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "7";//الدورة
            labelesm_Copy3.Content = "   2 , 9, 18, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_112(object sender, RoutedEventArgs e)//ce
        {
            reader.SpeakAsync("Cerium");
          
            labelesm.Content = "سيريوم";//الاسم
            labelesm_Copy.Content = "58";//العدد
            labelesm_Copy1.Content = "Ce";//الرمز
            labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "140.116";// الكتلة الذرية
            labelesm_Copy4.Content = "4f 5d 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "    2 , 9, 19, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ce.jpg", UriKind.Relative));

        }

        private void Button_Click_113(object sender, RoutedEventArgs e)//pe
        {
            reader.SpeakAsync("Praseodymium");
          
            labelesm.Content = "براسوديميوم";//الاسم
            labelesm_Copy.Content = "59";//العدد
            labelesm_Copy1.Content = "Pr";//الرمز
            labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "140.90765";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^3 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "    2 , 8, 21, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "pr.jpg", UriKind.Relative));

        }

        private void Button_Click_114(object sender, RoutedEventArgs e)//nd
        {
            reader.SpeakAsync("Neodymium");
           
            labelesm.Content = "نيوديميوم";//الاسم
            labelesm_Copy.Content = "60";//العدد
            labelesm_Copy1.Content = "Nd";//الرمز
            labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "144.242";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^4 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "    2 , 8, 22, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nd.jpg", UriKind.Relative));

        }

        private void Button_Click_115(object sender, RoutedEventArgs e)//pm
        {
            reader.SpeakAsync("Promethium");
               
            labelesm.Content = "بروميثيوم";//الاسم
            labelesm_Copy.Content = "61";//العدد
            labelesm_Copy1.Content = "Pm";//الرمز
            labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "145";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^5 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "    2 , 8, 23, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));

        }

        private void Button_Click_116(object sender, RoutedEventArgs e)//gd
        {
            reader.SpeakAsync("Gadolinium");
          
            labelesm.Content = "غادولينيوم";//الاسم
            labelesm_Copy.Content = "64";//العدد
            labelesm_Copy1.Content = "Gd";//الرمز
            labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "157.25";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^7 5d^1 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "    2 , 9, 25, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "gd.jpg", UriKind.Relative));

        }

        private void Button_Click_117(object sender, RoutedEventArgs e)//dy
        {
            reader.SpeakAsync("Dysprosium");
      
            labelesm.Content = "ديسبروسيوم";//الاسم
            labelesm_Copy.Content = "66";//العدد
            labelesm_Copy1.Content = "Dy";//الرمز
            labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "162.500";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^10 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "    2 , 8, 28, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "dy.jpg", UriKind.Relative));

        }

        private void Button_Click_118(object sender, RoutedEventArgs e)//yb
        {
            reader.SpeakAsync("Ytterbium");
     
            labelesm.Content = "إتيربيوم";//الاسم
            labelesm_Copy.Content = "70";//العدد
            labelesm_Copy1.Content = "Yb";//الرمز
            labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
            labelesm_Copy8.Content = "1-^غ·مول";
            labelesm_Copy9.Content = "173.054";// الكتلة الذرية
            labelesm_Copy4.Content = "4f^14 6s^2";//توزيع الالكتروني 
            labelesm_Copy5.Content = "f";//المستوى الفرعي 
            labelesm_Copy6.Content = "n/a";//المجموعة
            labelesm_Copy7.Content = "6";//الدورة
            labelesm_Copy3.Content = "    2 , 8, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "yb.jpg", UriKind.Relative));

        }

        private void Button_Click_119(object sender, RoutedEventArgs e)//مسح البيانات
        {
            labelesm.Content = "";//الاسم
            labelesm_Copy.Content = "";//العدد
            labelesm_Copy1.Content = "";//الرمز
            labelesm_Copy2.Content = "";//تصنيف العنصر
            labelesm_Copy8.Content = "";
            labelesm_Copy9.Content = "";// الكتلة الذرية
            labelesm_Copy4.Content = "";//توزيع الالكتروني 
            labelesm_Copy5.Content = "";//المستوى الفرعي 
            labelesm_Copy6.Content = "";//المجموعة
            labelesm_Copy7.Content = "";//الدورة
            labelesm_Copy3.Content = "";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "fadi.png", UriKind.Relative));


        }
        private void Chrome(object sender, RoutedEventArgs e)//مسح البيانات
        {
            labelesm.Content = "";//الاسم
            labelesm_Copy.Content = "";//العدد
            labelesm_Copy1.Content = "";//الرمز
            labelesm_Copy2.Content = "";//تصنيف العنصر
            labelesm_Copy8.Content = "";
            labelesm_Copy9.Content = "";// الكتلة الذرية
            labelesm_Copy4.Content = "";//توزيع الالكتروني 
            labelesm_Copy5.Content = "";//المستوى الفرعي 
            labelesm_Copy6.Content = "";//المجموعة
            labelesm_Copy7.Content = "";//الدورة
            labelesm_Copy3.Content = "";// توزيع الالكترون لكل غلاف 
            System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
            ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "fadi.png", UriKind.Relative));


        }
        private void searcher(object sender, RoutedEventArgs e) // search
        {

            string x = MyTextBox.Text;
            MyTextBox.Clear();
            int check = 1;
            if (x == "H" || x == "h" || x == "هيدروجين" || x == "1")
            {
                reader.SpeakAsync("Hydrogen");
               
                labelesm.Content = "هيدروجين";//الاسم
                labelesm_Copy.Content = "1";//العدد
                labelesm_Copy1.Content = "H";//الرمز
                labelesm_Copy2.Content = " لا فلز";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "1.00794";// الكتلة الذرية
                labelesm_Copy4.Content = "1s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "s";//المستوى الفرعي 
                labelesm_Copy6.Content = "1";//المجموعة
                labelesm_Copy7.Content = "1";//الدورة
                labelesm_Copy3.Content = "               1";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "H.jpg", UriKind.Relative));
                check = 0;
            }


            if (x == "na" || x == "Na" || x == "صوديوم" || x == "11")
            {
                reader.SpeakAsync("Sodium");

                labelesm.Content = "صوديوم";//الاسم
                labelesm_Copy.Content = "11";//العدد
                labelesm_Copy1.Content = "Na";//الرمز
                labelesm_Copy2.Content = "فلز قلوي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "22.98976928";// الكتلة الذرية
                labelesm_Copy4.Content = "3s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "s";//المستوى الفرعي 
                labelesm_Copy6.Content = "1";//المجموعة
                labelesm_Copy7.Content = "3";//الدورة
                labelesm_Copy3.Content = "                       2, 8 , 1";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "Na.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Bi" || x == "bi" || x == "بزموت" || x == "83")
            {
                labelesm.Content = "بزموت";//الاسم
                labelesm_Copy.Content = "83";//العدد
                labelesm_Copy1.Content = "Bi";//الرمز
                labelesm_Copy2.Content = " فلز بعد انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "208.98040 ";// الكتلة الذرية
                labelesm_Copy4.Content = "4f ^14  5d ^10  6s ^2  6p ^3";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "15";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "            2, 8, 18, 32, 18, 5";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "bi.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "Ca" || x == "ca" || x == "كالسيوم" || x == "20")
            {
                reader.SpeakAsync("Calcium");
              
                labelesm.Content = "كالسيوم";//الاسم
                labelesm_Copy.Content = "20";//العدد
                labelesm_Copy1.Content = "Ca";//الرمز
                labelesm_Copy2.Content = " فلز قلوي ترابي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "40.078";// الكتلة الذرية
                labelesm_Copy4.Content = "4s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "s";//المستوى الفرعي 
                labelesm_Copy6.Content = "2";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "              2 , 8 , 8 , 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ca.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "K" || x == "k" || x == "بوتاسيوم" || x == "19")
            {
                reader.SpeakAsync("Potassium");
          
                labelesm.Content = "بوتاسيوم";//الاسم
                labelesm_Copy.Content = "19";//العدد
                labelesm_Copy1.Content = "K";//الرمز
                labelesm_Copy2.Content = "فلز قلوي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "39.0983";// الكتلة الذرية
                labelesm_Copy4.Content = "4s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "s";//المستوى الفرعي 
                labelesm_Copy6.Content = "1";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "           1 , 8 , 8 , 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "k.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "Sc" || x == "sc" || x == "سكانديوم" || x == "21")
            {
                reader.SpeakAsync("Scandium");
              
                labelesm.Content = "سكانديوم";//الاسم
                labelesm_Copy.Content = "21";//العدد
                labelesm_Copy1.Content = "Sc";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "44.955912";// الكتلة الذرية
                labelesm_Copy4.Content = "3d^1 4s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "3";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "           2 , 9 , 8 , 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "sc.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Tc" || x == "tc" || x == "تكنيشيوم" || x == "43")
            {
                reader.SpeakAsync("Technetium");
               
                labelesm.Content = "تكنيشيوم";//الاسم
                labelesm_Copy.Content = "43";//العدد
                labelesm_Copy1.Content = "Tc";//الرمز
                labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "98";// الكتلة الذرية
                labelesm_Copy4.Content = "4d^5 5s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "7";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "         2, 13, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Be" || x == "be" || x == "بيريليوم" || x == "4")
            {
                reader.SpeakAsync("Beryllium");
               
                labelesm.Content = "بيريليوم";//الاسم
                labelesm_Copy.Content = "4";//العدد
                labelesm_Copy1.Content = "Be";//الرمز
                labelesm_Copy2.Content = "فلز قلوي ترابي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "9.012182";// الكتلة الذرية
                labelesm_Copy4.Content = "1s^2 2s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "2";//المجموعة
                labelesm_Copy7.Content = "2";//الدورة
                labelesm_Copy3.Content = "                   2, 2  ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "be.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "Li" || x == "li" || x == "ليثيوم" || x == "3")
            {
                reader.SpeakAsync("Lithium");
       
                labelesm.Content = "ليثيوم";//الاسم
                labelesm_Copy.Content = "3";//العدد
                labelesm_Copy1.Content = "Li";//الرمز
                labelesm_Copy2.Content = "فلز قلوي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "6.941";// الكتلة الذرية
                labelesm_Copy4.Content = "1s^2 2s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "s";//المستوى الفرعي 
                labelesm_Copy6.Content = "1";//المجموعة
                labelesm_Copy7.Content = "2";//الدورة
                labelesm_Copy3.Content = "                   1 , 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "li.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Mg" || x == "mg" || x == "مغنسيوم" || x == "12")
            {
                reader.SpeakAsync("Magnesium");
       
                labelesm.Content = "مغنسيوم";//الاسم
                labelesm_Copy.Content = "12";//العدد
                labelesm_Copy1.Content = "Mg";//الرمز
                labelesm_Copy2.Content = " فلز قلوي ترابي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "24.3050";// الكتلة الذرية
                labelesm_Copy4.Content = " 3s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "s";//المستوى الفرعي 
                labelesm_Copy6.Content = "2";//المجموعة
                labelesm_Copy7.Content = "3";//الدورة
                labelesm_Copy3.Content = "                  2, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "mg.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "Rb" || x == "rb" || x == "روبيديوم" || x == "37")
            {
                reader.SpeakAsync("Rubidium");
              
                labelesm.Content = "روبيديوم";//الاسم
                labelesm_Copy.Content = "37";//العدد
                labelesm_Copy1.Content = "Rb";//الرمز
                labelesm_Copy2.Content = "فلز قلوي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "85.4678";// الكتلة الذرية
                labelesm_Copy4.Content = "5s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "s";//المستوى الفرعي 
                labelesm_Copy6.Content = "1";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "         1, 8, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "rb.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "Sr" || x == "sr" || x == "سترونشيوم" || x == "38")
            {
                reader.SpeakAsync("Strontium");
                labelesm.Content = "سترونشيوم";//الاسم
                labelesm_Copy.Content = "38";//العدد
                labelesm_Copy1.Content = "Sr";//الرمز
                labelesm_Copy2.Content = "فلز قلوي ترابي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "88.90585";// الكتلة الذرية
                labelesm_Copy4.Content = "4d^1 5s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "3";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "       2, 9, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "sr.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Cs" || x == "cs" || x == "سيزيوم" || x == "55")
            {
                reader.SpeakAsync("Caesium");
               
                labelesm.Content = "سيزيوم";//الاسم
                labelesm_Copy.Content = "55";//العدد
                labelesm_Copy1.Content = "Cs";//الرمز
                labelesm_Copy2.Content = "فلز قلوي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "132.9054519";// الكتلة الذرية
                labelesm_Copy4.Content = " 6s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "s";//المستوى الفرعي 
                labelesm_Copy6.Content = "1";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "     1 , 8 , 18, 18, 8 , 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "cs.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Ba" || x == "ba" || x == "باريوم" || x == "56")
            {
                reader.SpeakAsync("Barium");
              
                labelesm.Content = "باريوم";//الاسم
                labelesm_Copy.Content = "56";//العدد
                labelesm_Copy1.Content = "Ba";//الرمز
                labelesm_Copy2.Content = "فلز قلوي ترابي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "137.33";// الكتلة الذرية
                labelesm_Copy4.Content = " 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "s";//المستوى الفرعي 
                labelesm_Copy6.Content = "2";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "      2 , 8 , 18, 18, 8 , 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ba.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "Fr" || x == "fr" || x == "فرانسيوم" || x == "87")
            {
                reader.SpeakAsync("Francium");
              
                labelesm.Content = "فرانسيوم";//الاسم
                labelesm_Copy.Content = "87";//العدد
                labelesm_Copy1.Content = "Fr";//الرمز
                labelesm_Copy2.Content = "فلز قلوي ";//تصنيف العنصر
                labelesm_Copy9.Content = "223";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = "7s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "s";//المستوى الفرعي 
                labelesm_Copy6.Content = "1";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "1 , 8, 18, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Ra" || x == "ra" || x == "راديوم" || x == "88")
            {
                reader.SpeakAsync("Radium");
               
                labelesm.Content = "راديوم";//الاسم
                labelesm_Copy.Content = "88";//العدد
                labelesm_Copy1.Content = "Ra";//الرمز
                labelesm_Copy2.Content = "فلز قلوي ترابي";//تصنيف العنصر
                labelesm_Copy9.Content = "226";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = "7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "s";//المستوى الفرعي 
                labelesm_Copy6.Content = "18";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "2 , 8, 18, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ra.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Y" || x == "y" || x == "اتريوم" || x == "39")
            {
                reader.SpeakAsync("Yttrium");
     
                labelesm.Content = "اتريوم";//الاسم
                labelesm_Copy.Content = "39";//العدد
                labelesm_Copy1.Content = "Y";//الرمز
                labelesm_Copy2.Content = " فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "88.90585";// الكتلة الذرية
                labelesm_Copy4.Content = "4d^1 5s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "3";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "      2, 9, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "y.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "Ti" || x == "ti" || x == "تيتانيوم" || x == "22")
            {
                reader.SpeakAsync("Titanium");
     
                labelesm.Content = "تيتانيوم";//الاسم
                labelesm_Copy.Content = "22";//العدد
                labelesm_Copy1.Content = "Ti";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "47.867";// الكتلة الذرية
                labelesm_Copy4.Content = "3d^2 4s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "4";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "           2 , 10 , 8 , 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ti.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Zr" || x == "zr" || x == "زركونيوم" || x == "40")
            {
                reader.SpeakAsync("Zirconium");
              

                labelesm.Content = "زركونيوم";//الاسم
                labelesm_Copy.Content = "40";//العدد
                labelesm_Copy1.Content = "Zr";//الرمز
                labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "91.224";// الكتلة الذرية
                labelesm_Copy4.Content = "5s^2 4d^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "4";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "            2, 10, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "zr.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Hf" || x == "hf" || x == "هافنيوم" || x == "72")
            {
                reader.SpeakAsync("Hafnium");
               
                labelesm.Content = "هافنيوم";//الاسم
                labelesm_Copy.Content = "72";//العدد
                labelesm_Copy1.Content = "Hf";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy9.Content = "178.49";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = "4f^14 5d^2 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "4";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "    2 , 10, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "hf.jpg", UriKind.Relative));

                check = 0;
            }

            if (x == "Rf" || x == "rf" || x == "رذرفورديوم" || x == "104")
            {
                reader.SpeakAsync("Rutherfordium");
       
                labelesm.Content = "رذرفورديوم";//الاسم
                labelesm_Copy.Content = "104";//العدد
                labelesm_Copy1.Content = "Rf";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy9.Content = "261.11";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = " 5f^14 6d^2 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "4";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2 , 10, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Db" || x == "db" || x == "دوبنيوم" || x == "105")
            {
                reader.SpeakAsync("Dubnium");
              
                labelesm.Content = "دوبنيوم";//الاسم
                labelesm_Copy.Content = "105";//العدد
                labelesm_Copy1.Content = "Db";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "268";// الكتلة الذرية
                labelesm_Copy4.Content = "5f^14 6d^3 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "5";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2, 11, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Ta" || x == "ta" || x == "تانتالوم" || x == "73")
            {
                reader.SpeakAsync("Tantalum");
               
                labelesm.Content = "تانتالوم";//الاسم
                labelesm_Copy.Content = "73";//العدد
                labelesm_Copy1.Content = "Ta";//الرمز
                labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "180.94788";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^14 5d^3 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "5";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "     2, 11, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ta.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Nb" || x == "nb" || x == "نيوبيوم" || x == "41")
            {
                reader.SpeakAsync("Niobium");

                labelesm.Content = "نيوبيوم";//الاسم
                labelesm_Copy.Content = "41";//العدد
                labelesm_Copy1.Content = "Nb";//الرمز
                labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "92.90638";// الكتلة الذرية
                labelesm_Copy4.Content = "4d^4 5s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "5";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "            1, 12, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nb.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "V" || x == "v" || x == "فاناديوم" || x == "23")
            {
                reader.SpeakAsync("Vanadium");
                labelesm.Content = "فاناديوم";//الاسم
                labelesm_Copy.Content = "23";//العدد
                labelesm_Copy1.Content = "V";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "50.9415";// الكتلة الذرية
                labelesm_Copy4.Content = "3d^3 4s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "5";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "              2 , 11 , 8 , 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "v.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "Cr" || x == "cr" || x == "كروم" || x == "24")
            {
                reader.SpeakAsync("Chromium");
              
                labelesm.Content = "كروم";//الاسم
                labelesm_Copy.Content = "24";//العدد
                labelesm_Copy1.Content = "Cr";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = " 51.9961";// الكتلة الذرية
                labelesm_Copy4.Content = "3d^5 4s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "6";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "                1 , 13 , 8 , 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "cr.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "Mo" || x == "mo" || x == "موليبدنوم" || x == "42")
            {
                reader.SpeakAsync("Molybdenum");
              
                labelesm.Content = "موليبدنوم";//الاسم
                labelesm_Copy.Content = "42";//العدد
                labelesm_Copy1.Content = "Mo";//الرمز
                labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "95.96";// الكتلة الذرية
                labelesm_Copy4.Content = "5s^1 4d^5";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "6";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "           1, 13, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "mo.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "W" || x == "w" || x == "تنغستن" || x == "74")
            {
                reader.SpeakAsync("Tungsten");
           
                labelesm.Content = "تنغستن";//الاسم
                labelesm_Copy.Content = "74";//العدد
                labelesm_Copy1.Content = "W";//الرمز
                labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "183.84";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^14 5d^4 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "6";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "     2, 12, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "w.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Sg" || x == "sg" || x == "سيبورغيوم" || x == "106")
            {
                labelesm.Content = "سيبورغيوم";//الاسم
                labelesm_Copy.Content = "106";//العدد
                labelesm_Copy1.Content = "Sg";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "271";// الكتلة الذرية
                labelesm_Copy4.Content = "7s^2 5f^14 6d^4";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "7";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "2, 12, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Bh" || x == "bh" || x == "بوريوم" || x == "107")
            {
                reader.SpeakAsync("Bohrium");
         
                labelesm.Content = "بوريوم";//الاسم
                labelesm_Copy.Content = "107";//العدد
                labelesm_Copy1.Content = "Bh";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "54.938045";// الكتلة الذرية
                labelesm_Copy4.Content = "4s^2 3d^5";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "7";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "2, 8, 18, 32, 32, 13, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Re" || x == "re" || x == "رينيوم" || x == "75")
            {
                reader.SpeakAsync("Rhenium");
          
                labelesm.Content = "رينيوم";//الاسم
                labelesm_Copy.Content = "75";//العدد
                labelesm_Copy1.Content = "Re";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "186.207";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^14 5d^5 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "6";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "    2 , 13 , 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "re.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Mn" || x == "mn" || x == "منغنيز" || x == "25")
            {
                reader.SpeakAsync("Manganese");
              
                labelesm.Content = "منغنيز";//الاسم
                labelesm_Copy.Content = "25";//العدد
                labelesm_Copy1.Content = "Mn";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "54.938045";// الكتلة الذرية
                labelesm_Copy4.Content = "4s^2 3d^5";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "7";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "            2 , 13 , 8 , 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "mn.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Fe" || x == "fe" || x == "حديد" || x == "26")
            {
                reader.SpeakAsync("Iron");
              
                labelesm.Content = "حديد";//الاسم
                labelesm_Copy.Content = "26";//العدد
                labelesm_Copy1.Content = "Fe";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "55.845";// الكتلة الذرية
                labelesm_Copy4.Content = "3d^6 4s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "8";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "               2 , 14 , 8 , 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "fe.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Ru" || x == "ru" || x == "روثينيوم" || x == "44")
            {
                reader.SpeakAsync("Ruthenium");
        
                labelesm.Content = "روثينيوم";//الاسم
                labelesm_Copy.Content = "44";//العدد
                labelesm_Copy1.Content = "Ru";//الرمز
                labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "101.07";// الكتلة الذرية
                labelesm_Copy4.Content = "4d^7 5s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "8";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "           1, 15, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ru.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Os" || x == "os" || x == "أوزميوم" || x == "76")
            {
                reader.SpeakAsync("Osmium");
              
                labelesm.Content = "أوزميوم";//الاسم
                labelesm_Copy.Content = "76";//العدد
                labelesm_Copy1.Content = "Os";//الرمز
                labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "190.23";// الكتلة الذرية
                labelesm_Copy4.Content = " 4f^14 5d^6 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "8";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "     2, 14, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "os.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Hs" || x == "hs" || x == "هاسيوم" || x == "108")
            {
                reader.SpeakAsync("Hassium");
        
                labelesm.Content = "هاسيوم";//الاسم
                labelesm_Copy.Content = "108";//العدد
                labelesm_Copy1.Content = "Hs";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "269";// الكتلة الذرية
                labelesm_Copy4.Content = "5f^14 6d^6 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "8";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2 , 14 , 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Mt" || x == "mt" || x == "مايتنريوم" || x == "109")
            {
                reader.SpeakAsync("Meitnerium");
               
                labelesm.Content = "مايتنريوم";//الاسم
                labelesm_Copy.Content = "109";//العدد
                labelesm_Copy1.Content = "Mt";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "278";// الكتلة الذرية
                labelesm_Copy4.Content = "7s^2 5f^14 6d^7";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "9";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2 , 15, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Ir" || x == "ir" || x == "إريديوم" || x == "77")
            {
                reader.SpeakAsync("Iridium");
           
                labelesm.Content = "إريديوم";//الاسم
                labelesm_Copy.Content = "77";//العدد
                labelesm_Copy1.Content = "Ir";//الرمز
                labelesm_Copy2.Content = " فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "192.217";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^14 5d^7 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "9";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "     2, 15, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ir.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Rh" || x == "rh" || x == "روديوم" || x == "45")
            {
                reader.SpeakAsync("Rhodium");
               
                labelesm.Content = "روديوم";//الاسم
                labelesm_Copy.Content = "45";//العدد
                labelesm_Copy1.Content = "Rh";//الرمز
                labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "102.90550";// الكتلة الذرية
                labelesm_Copy4.Content = "5s^1 4d^8";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "9";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "              1, 16, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "rH.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Co" || x == "co" || x == "كوبالت" || x == "27")
            {
                reader.SpeakAsync("Cobalt");
              
                labelesm.Content = "كوبالت";//الاسم
                labelesm_Copy.Content = "27";//العدد
                labelesm_Copy1.Content = "Co";//الرمز
                labelesm_Copy2.Content = " فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "58.933195";// الكتلة الذرية
                labelesm_Copy4.Content = " 4s^2 3d^7";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "9";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "               2, 15 , 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "co.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Ni" || x == "ni" || x == "نيكل" || x == "28")
            {
                reader.SpeakAsync("Nickel");
       
                labelesm.Content = "نيكل";//الاسم
                labelesm_Copy.Content = "28";//العدد
                labelesm_Copy1.Content = "Ni";//الرمز
                labelesm_Copy2.Content = " فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "58.6934";// الكتلة الذرية
                labelesm_Copy4.Content = "4s^1 3d^9";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "10";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "               1, 17 , 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ni.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Pd" || x == "pd" || x == "بالاديوم" || x == "46")
            {
                reader.SpeakAsync("Palladium");
         
                labelesm.Content = "بالاديوم";//الاسم
                labelesm_Copy.Content = "46";//العدد
                labelesm_Copy1.Content = "Pd";//الرمز
                labelesm_Copy2.Content = "فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "106.42";// الكتلة الذرية
                labelesm_Copy4.Content = "4d^10 ";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "10";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "                18, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "pd.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Pt" || x == "pt" || x == "بلاتين" || x == "78")
            {
                reader.SpeakAsync("Platinum");
       
                labelesm.Content = "بلاتين";//الاسم
                labelesm_Copy.Content = "78";//العدد
                labelesm_Copy1.Content = "Pt";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "195.084";// الكتلة الذرية
                labelesm_Copy4.Content = " 4f^14 5d^9 6s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "2";//المجموعة
                labelesm_Copy7.Content = "10";//الدورة
                labelesm_Copy3.Content = "       1, 17, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "pt.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Ds" || x == "ds" || x == "دارمشتاتيوم" || x == "110")
            {
                reader.SpeakAsync("Darmstadtium");
             
                labelesm.Content = "دارمشتاتيوم";//الاسم
                labelesm_Copy.Content = "110";//العدد
                labelesm_Copy1.Content = "Ds";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "281";// الكتلة الذرية
                labelesm_Copy4.Content = "7s^1 5f^14 6d^9";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "2";//المجموعة
                labelesm_Copy7.Content = "10";//الدورة
                labelesm_Copy3.Content = "1, 17, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;

            }

            if (x == "Rg" || x == "rg" || x == "رونتجينيوم" || x == "111")
            {
                reader.SpeakAsync("Roentgenium");
               
                labelesm.Content = "رونتجينيوم";//الاسم
                labelesm_Copy.Content = "111";//العدد
                labelesm_Copy1.Content = "Rg";//الرمز
                labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "101.07";// الكتلة الذرية
                labelesm_Copy4.Content = " 5f^14 6d^10 7s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "11";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "1, 18, 32 , 32, 18 ,8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Au" || x == "au" || x == "الذهب" || x == "79")
            {
                reader.SpeakAsync("Gold");
              
                labelesm.Content = "الذهب";//الاسم
                labelesm_Copy.Content = "79";//العدد
                labelesm_Copy1.Content = "Au";//الرمز
                labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "190.23";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^14 5d^6 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "8";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "     2, 14, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "au.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Ag" || x == "ag" || x == "فضة" || x == "47")
            {
                reader.SpeakAsync("Silver");
       
                labelesm.Content = "فضة";//الاسم
                labelesm_Copy.Content = "47";//العدد
                labelesm_Copy1.Content = "Ag";//الرمز
                labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "107.8682";// الكتلة الذرية
                labelesm_Copy4.Content = "4d^10 5s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "11";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "             1, 18, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ag.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Cu" || x == "cu" || x == "نحاس" || x == "29")
            {
                reader.SpeakAsync("Copper");
       
                labelesm.Content = "نحاس";//الاسم
                labelesm_Copy.Content = "29";//العدد
                labelesm_Copy1.Content = "Cu";//الرمز
                labelesm_Copy2.Content = " فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "63.546";// الكتلة الذرية
                labelesm_Copy4.Content = "3d^10 4s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "11";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "               1, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "cu.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "Zn" || x == "zn" || x == "زنك" || x == "30")
            {
                reader.SpeakAsync("Zinc");
                labelesm.Content = "زنك";//الاسم
                labelesm_Copy.Content = "30";//العدد
                labelesm_Copy1.Content = "Zn";//الرمز
                labelesm_Copy2.Content = " فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "65.38";// الكتلة الذرية
                labelesm_Copy4.Content = "3d^10 4s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "12";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "              2, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "zn.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "Cd" || x == "cd" || x == "كادميوم" || x == "48")
            {
                reader.SpeakAsync("Cadmium");
                labelesm.Content = "كادميوم";//الاسم
                labelesm_Copy.Content = "48";//العدد
                labelesm_Copy1.Content = "Cd";//الرمز
                labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "112.411";// الكتلة الذرية
                labelesm_Copy4.Content = " 5s^2 4d^10";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "12";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "            2, 18, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "cd.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Hg" || x == "hg" || x == "زئبق" || x == "80")
            {
                reader.SpeakAsync("Mercury ");
                labelesm.Content = "زئبق";//الاسم
                labelesm_Copy.Content = "80";//العدد
                labelesm_Copy1.Content = "Hg";//الرمز
                labelesm_Copy2.Content = " فلز  انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "200.59";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^14 5d^10 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "12";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "     2, 18, 32, 18 , 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "hg.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Cn" || x == "cn" || x == "كوبرنيسيوم" || x == "112")
            {
                reader.SpeakAsync("Copernicium");
              
                labelesm.Content = "كوبرنيسيوم";//الاسم
                labelesm_Copy.Content = "112";//العدد
                labelesm_Copy1.Content = "Cn";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "285";// الكتلة الذرية
                labelesm_Copy4.Content = "5f^14 6d^10 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "12";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2 , 18, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "He" || x == "he" || x == "هيليوم" || x == "2")
            {
                reader.SpeakAsync("Helium");
       
                labelesm.Content = "هيليوم";//الاسم
                labelesm_Copy.Content = "2";//العدد
                labelesm_Copy1.Content = "He";//الرمز
                labelesm_Copy2.Content = "غاز نبيل";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "4.002602";// الكتلة الذرية
                labelesm_Copy4.Content = "1s^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "s";//المستوى الفرعي 
                labelesm_Copy6.Content = "18";//المجموعة
                labelesm_Copy7.Content = "1";//الدورة
                labelesm_Copy3.Content = "                  2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "he.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "B" || x == "b" || x == "بورون" || x == "5")
            {
                reader.SpeakAsync("Boron");
               
                labelesm.Content = "بورون";//الاسم
                labelesm_Copy.Content = "5";//العدد
                labelesm_Copy1.Content = "B";//الرمز
                labelesm_Copy2.Content = "شبه فلز";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "10.811";// الكتلة الذرية
                labelesm_Copy4.Content = " 2s^2 2p^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = " p";//المستوى الفرعي 
                labelesm_Copy6.Content = "13";//المجموعة
                labelesm_Copy7.Content = "2";//الدورة
                labelesm_Copy3.Content = "               3 ,2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "b.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "C" || x == "c" || x == "كربون" || x == "6")
            {
                reader.SpeakAsync("Carbon");
        
                labelesm.Content = "كربون";//الاسم
                labelesm_Copy.Content = "6";//العدد
                labelesm_Copy1.Content = "C";//الرمز
                labelesm_Copy2.Content = "لا فلز";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "12.0107";// الكتلة الذرية
                labelesm_Copy4.Content = "2s^2 2p^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "14";//المجموعة
                labelesm_Copy7.Content = "2";//الدورة
                labelesm_Copy3.Content = "               2, 4";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "c.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "N" || x == "n" || x == "نيتروجين" || x == "7")
            {
                reader.SpeakAsync("Nitrogen");
        
                labelesm.Content = "نيتروجين";//الاسم
                labelesm_Copy.Content = "7";//العدد
                labelesm_Copy1.Content = "N";//الرمز
                labelesm_Copy2.Content = "لا فلز";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "14.0067";// الكتلة الذرية
                labelesm_Copy4.Content = "1s^2 2s^2 2p^3";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "15";//المجموعة
                labelesm_Copy7.Content = "2";//الدورة
                labelesm_Copy3.Content = "                5, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "N.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "O" || x == "o" || x == "اكسجين" || x == "أكسجين" || x == "8")
            {
                reader.SpeakAsync("Oxygen");
       
                labelesm.Content = "أكسجين";//الاسم
                labelesm_Copy.Content = "8";//العدد
                labelesm_Copy1.Content = "O";//الرمز
                labelesm_Copy2.Content = "لا فلز, كالكوجين";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "15.9994";// الكتلة الذرية
                labelesm_Copy4.Content = "1s^2 2s^2 2p^4";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "16";//المجموعة
                labelesm_Copy7.Content = "2";//الدورة
                labelesm_Copy3.Content = "                 6, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "o.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "F" || x == "f" || x == "فلور" || x == "9")
            {
                reader.SpeakAsync("Fluorine");
            
                labelesm.Content = "فلور";//الاسم
                labelesm_Copy.Content = "9";//العدد
                labelesm_Copy1.Content = "F";//الرمز
                labelesm_Copy2.Content = "هالوجين";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "18.9984032";// الكتلة الذرية
                labelesm_Copy4.Content = "1s^2 2s^2 2p^5";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "17";//المجموعة
                labelesm_Copy7.Content = "2";//الدورة
                labelesm_Copy3.Content = "               7, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "f.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Ne" || x == "ne" || x == "نيون" || x == "10")
            {
                reader.SpeakAsync("Neon");
               
                labelesm.Content = "نيون";//الاسم
                labelesm_Copy.Content = "10";//العدد
                labelesm_Copy1.Content = "Ne";//الرمز
                labelesm_Copy2.Content = "غاز نبيل";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "20.1797";// الكتلة الذرية
                labelesm_Copy4.Content = "1s^2 2s^2 2p^6";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "18";//المجموعة
                labelesm_Copy7.Content = "2";//الدورة
                labelesm_Copy3.Content = "               8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "Ne.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Al" || x == "al" || x == "ألومنيوم" || x == "13")
            {
                reader.SpeakAsync("Aluminium");
           
                labelesm.Content = "ألومنيوم";//الاسم
                labelesm_Copy.Content = "13";//العدد
                labelesm_Copy1.Content = "Al";//الرمز
                labelesm_Copy2.Content = "فلز آخر";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "26.9815386";// الكتلة الذرية
                labelesm_Copy4.Content = " 3s^2 3p^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "13";//المجموعة
                labelesm_Copy7.Content = "3";//الدورة
                labelesm_Copy3.Content = "                3, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "al.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Si" || x == "si" || x == "سليكون" || x == "14")
            {
                reader.SpeakAsync("Silicon");
        
                labelesm.Content = "سليكون";//الاسم
                labelesm_Copy.Content = "14";//العدد
                labelesm_Copy1.Content = "Si";//الرمز
                labelesm_Copy2.Content = "شبه فلز";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "28.0855";// الكتلة الذرية
                labelesm_Copy4.Content = "  3s^2 3p^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "14";//المجموعة
                labelesm_Copy7.Content = "3";//الدورة
                labelesm_Copy3.Content = "                4, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "si.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "P" || x == "p" || x == "فسفور" || x == "15")
            {
                reader.SpeakAsync("Phosphorus");
             
                labelesm.Content = "فسفور";//الاسم
                labelesm_Copy.Content = "15";//العدد
                labelesm_Copy1.Content = "P";//الرمز
                labelesm_Copy2.Content = "لا فلز";//تصنيف العنصر
                labelesm_Copy9.Content = "30.973762";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = "3s^2 3p^3";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "15";//المجموعة
                labelesm_Copy7.Content = "3";//الدورة
                labelesm_Copy3.Content = "               5, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "p.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "S" || x == "s" || x == "كبريت" || x == "16")
            {
                reader.SpeakAsync("Sulfur");
       
                labelesm.Content = "كبريت";//الاسم
                labelesm_Copy.Content = "16";//العدد
                labelesm_Copy1.Content = "S";//الرمز
                labelesm_Copy2.Content = "لا فلز";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "32.065";// الكتلة الذرية
                labelesm_Copy4.Content = "3s^2 3p^4";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "16";//المجموعة
                labelesm_Copy7.Content = "3";//الدورة
                labelesm_Copy3.Content = "                6, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "s.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Cl" || x == "cl" || x == "كلور" || x == "17")
            {
                reader.SpeakAsync("Chlorine");
       
                labelesm.Content = "كلور";//الاسم
                labelesm_Copy.Content = "17";//العدد
                labelesm_Copy1.Content = "Cl";//الرمز
                labelesm_Copy2.Content = "هالوجين";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "35.453";// الكتلة الذرية
                labelesm_Copy4.Content = "3s^2 3p^5";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "17";//المجموعة
                labelesm_Copy7.Content = "3";//الدورة
                labelesm_Copy3.Content = "                7, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "cl.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Ar" || x == "ar" || x == "أرغون" || x == "18")
            {
                reader.SpeakAsync("Argon");
       
                labelesm.Content = "أرغون";//الاسم
                labelesm_Copy.Content = "18";//العدد
                labelesm_Copy1.Content = "Ar";//الرمز
                labelesm_Copy2.Content = " غاز نبيل";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "39.948";// الكتلة الذرية
                labelesm_Copy4.Content = "3s^2 3p^6";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "18";//المجموعة
                labelesm_Copy7.Content = "3";//الدورة
                labelesm_Copy3.Content = "                8, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ar.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Ga" || x == "ga" || x == "غاليوم" || x == "31")
            {
                reader.SpeakAsync("Gallium");
               
                labelesm.Content = "غاليوم";//الاسم
                labelesm_Copy.Content = "31";//العدد
                labelesm_Copy1.Content = "Ga";//الرمز
                labelesm_Copy2.Content = "فلز انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "69.723";// الكتلة الذرية
                labelesm_Copy4.Content = " 4s^2 3d^10 4p^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "13";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "               3, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ga.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "Ge" || x == "ge" || x == "جرمانيوم" || x == "32")
            {
                reader.SpeakAsync("Germanium");
              
                labelesm.Content = "جرمانيوم";//الاسم
                labelesm_Copy.Content = "32";//العدد
                labelesm_Copy1.Content = "Ge";//الرمز
                labelesm_Copy2.Content = "شبه فلز";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "72.64";// الكتلة الذرية
                labelesm_Copy4.Content = " 3d^10 4s^2 4p^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "14";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "               4, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ge.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "As" || x == "as" || x == "زرنيخ" || x == "33")
            {
                reader.SpeakAsync("Arsenic");
       
                labelesm.Content = "زرنيخ";//الاسم
                labelesm_Copy.Content = "33";//العدد
                labelesm_Copy1.Content = "As";//الرمز
                labelesm_Copy2.Content = "شبه فلز";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "74.92160";// الكتلة الذرية
                labelesm_Copy4.Content = "4s^2 3d^10 4p^3";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "15";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "               5, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "as.jpg", UriKind.Relative));

                check = 0;
            }


            if (x == "Br" || x == "br" || x == "بروم" || x == "35")
            {
                reader.SpeakAsync("Bromine");
             
                labelesm.Content = "بروم";//الاسم
                labelesm_Copy.Content = "35";//العدد
                labelesm_Copy1.Content = "Br";//الرمز
                labelesm_Copy2.Content = "هالوجين";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "79.904";// الكتلة الذرية
                labelesm_Copy4.Content = "4s^2 3d^10 4p^5";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "17";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "                7, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "br.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Kr" || x == "kr" || x == "كريبتون" || x == "36")
            {
                reader.SpeakAsync("Krypton");
               
                labelesm.Content = "كريبتون";//الاسم
                labelesm_Copy.Content = "36";//العدد
                labelesm_Copy1.Content = "Kr";//الرمز
                labelesm_Copy2.Content = "غاز نبيل";//تصنيف العنصر
                labelesm_Copy9.Content = "83.798";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = "3d^10 4s^2 4p^6";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "18";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "                8, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "kr.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "In" || x == "in" || x == "إنديوم" || x == "49")
            {
                reader.SpeakAsync("Indium");
        
                labelesm.Content = "إنديوم";//الاسم
                labelesm_Copy.Content = "49";//العدد
                labelesm_Copy1.Content = "In";//الرمز
                labelesm_Copy2.Content = " فلز بعد انتقالي";//تصنيف العنصر
                labelesm_Copy9.Content = "114.818";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = "4d^10 5s^2 5p^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "13";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "              3, 18, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "in.jpg", UriKind.Relative));
                check = 0;

            }

            if (x == "Sn" || x == "sn" || x == "قصدير" || x == "50")
            {
                reader.SpeakAsync("Tin");
        
                labelesm.Content = "قصدير";//الاسم
                labelesm_Copy.Content = "50";//العدد
                labelesm_Copy1.Content = "Sn";//الرمز
                labelesm_Copy2.Content = " فلز بعد انتقالي";//تصنيف العنصر
                labelesm_Copy9.Content = "118.710";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = "4d^10 5s^2 5p^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "14";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "               4, 18, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "sn.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Sb" || x == "sb" || x == "اثمد" || x == "51")
            {
                reader.SpeakAsync("Antimony");
             
                labelesm.Content = "اثمد";//الاسم
                labelesm_Copy.Content = "51";//العدد
                labelesm_Copy1.Content = "Sb";//الرمز
                labelesm_Copy2.Content = " شبه فلز";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "121.760";// الكتلة الذرية
                labelesm_Copy4.Content = "4d^10 5s^2 5p^3";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "15";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "               5, 18, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "sb.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Te" || x == "te" || x == "تيلوريوم" || x == "52")
            {
                reader.SpeakAsync("Tellurium");
           
                labelesm.Content = "تيلوريوم";//الاسم
                labelesm_Copy.Content = "52";//العدد
                labelesm_Copy1.Content = "Te";//الرمز
                labelesm_Copy2.Content = "شبه فلز";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "127.60";// الكتلة الذرية
                labelesm_Copy4.Content = " 4d^10 5s^2 5p^4";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "16";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "              6, 18, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "te.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "I" || x == "i" || x == "يود" || x == "53")
            {
                reader.SpeakAsync("Iodine");
       
                labelesm.Content = "يود";//الاسم
                labelesm_Copy.Content = "53";//العدد
                labelesm_Copy1.Content = "I";//الرمز
                labelesm_Copy2.Content = "هالوجين";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "126.90447";// الكتلة الذرية
                labelesm_Copy4.Content = " 4d^10 5s^2 5p^5";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "17";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "     7, 18, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "i.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Xe" || x == "xe" || x == "زينون" || x == "54")
            {
                reader.SpeakAsync("Xenon");
       
                labelesm.Content = "زينون";//الاسم
                labelesm_Copy.Content = "54";//العدد
                labelesm_Copy1.Content = "Xe";//الرمز
                labelesm_Copy2.Content = "غاز نبيل";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "131.293";// الكتلة الذرية
                labelesm_Copy4.Content = "5s^2 4d^10 5p^6";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "18";//المجموعة
                labelesm_Copy7.Content = "5";//الدورة
                labelesm_Copy3.Content = "         8, 18 , 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "xe.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Tl" || x == "tl" || x == "ثاليوم" || x == "81")
            {
                reader.SpeakAsync("Thallium");
             
                labelesm.Content = "ثاليوم";//الاسم
                labelesm_Copy.Content = "81";//العدد
                labelesm_Copy1.Content = "Tl";//الرمز
                labelesm_Copy2.Content = "فلز بعد انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "204.3833";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^14 5d^10 6s^2 6p^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "13";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "     3, 18 , 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ti.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Pb" || x == "pb" || x == "رصاص" || x == "82")
            {
                reader.SpeakAsync("Lead");
             
                labelesm.Content = "رصاص";//الاسم
                labelesm_Copy.Content = "82";//العدد
                labelesm_Copy1.Content = "Pb";//الرمز
                labelesm_Copy2.Content = "فلز بعد انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "207.2";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^14 5d^10 6s^2 6p^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "14";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "      4, 18 , 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "pb.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Bi" || x == "bi" || x == "بزموت" || x == "83")
            {
                reader.SpeakAsync("Bismuth");
       
                labelesm.Content = "بزموت";//الاسم
                labelesm_Copy.Content = "83";//العدد
                labelesm_Copy1.Content = "Bi";//الرمز
                labelesm_Copy2.Content = " فلز بعد انتقالي";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "208.98040";// الكتلة الذرية
                labelesm_Copy4.Content = "4f ^14  5d ^10  6s ^2  6p ^3";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "15";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "      2, 8, 18, 32, 18, 5";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "bi.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Po" || x == "po" || x == "بولونيوم" || x == "84")
            {
                reader.SpeakAsync("Polonium");
       
                labelesm.Content = "بولونيوم";//الاسم
                labelesm_Copy.Content = "84";//العدد
                labelesm_Copy1.Content = "Po";//الرمز
                labelesm_Copy2.Content = "شبه فلز";//تصنيف العنصر
                labelesm_Copy9.Content = "209";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = " 6s^2 4f^14 5d^10 6p^4";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "16";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "      6, 18, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "At" || x == "at" || x == "أستاتين" || x == "85")
            {
                reader.SpeakAsync("Astatine");
               
                labelesm.Content = "أستاتين";//الاسم
                labelesm_Copy.Content = "85";//العدد
                labelesm_Copy1.Content = "At";//الرمز
                labelesm_Copy2.Content = " شبه فلز";//تصنيف العنصر
                labelesm_Copy9.Content = "210";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = "4f^14 5d^10 6s^2 6p^5";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "17";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "     7, 18, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Rn" || x == "rn" || x == "رادون" || x == "86")
            {
                reader.SpeakAsync("Radon");
               
                labelesm.Content = "رادون";//الاسم
                labelesm_Copy.Content = "86";//العدد
                labelesm_Copy1.Content = "Rn";//الرمز
                labelesm_Copy2.Content = "غاز نبيل";//تصنيف العنصر
                labelesm_Copy9.Content = "222";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = "4f^14 5d^10 6s^2 6p^6";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "18";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "    8, 18, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Uut" || x == "uut" || x == "أنون تريوم" || x == "113")
            {
                reader.SpeakAsync("Ununtrium");
        
                labelesm.Content = "أنون تريوم";//الاسم
                labelesm_Copy.Content = "113";//العدد
                labelesm_Copy1.Content = "Uut";//الرمز
                labelesm_Copy2.Content = "افتراضيا فلز ضعيف";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "286";// الكتلة الذرية
                labelesm_Copy4.Content = "5f^14 6d^10 7s^2 7p^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "13";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "3 , 18, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Fl" || x == "fl" || x == "فليروفيوم" || x == "114")
            {
                reader.SpeakAsync("Flerovium");
        
                labelesm.Content = "فليروفيوم";//الاسم
                labelesm_Copy.Content = "114";//العدد
                labelesm_Copy1.Content = "Fl";//الرمز
                labelesm_Copy2.Content = "غير معروف";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "289";// الكتلة الذرية
                labelesm_Copy4.Content = "5f^14 6d^10 7s^2 7p^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "14";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "4 , 18, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Uup" || x == "uup" || x == "أنون بنتيوم" || x == "115")
            {
                reader.SpeakAsync("Ununpentium");
            
                labelesm.Content = "أنون بنتيوم";//الاسم
                labelesm_Copy.Content = "115";//العدد
                labelesm_Copy1.Content = "Uup";//الرمز
                labelesm_Copy2.Content = "غير معروف";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "289";// الكتلة الذرية
                labelesm_Copy4.Content = "5f^14 6d^10 7s^2 7p^3";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "15";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "5 , 18, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Lv" || x == "lv" || x == "ليفرموريوم" || x == "116")
            {
                reader.SpeakAsync("Livermorium");
             
                labelesm.Content = "ليفرموريوم";//الاسم
                labelesm_Copy.Content = "116";//العدد
                labelesm_Copy1.Content = "Lv";//الرمز
                labelesm_Copy2.Content = "غير معروف";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "293";// الكتلة الذرية
                labelesm_Copy4.Content = "5f^14 6d^10 7s^2 7p^4";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "16";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "6 , 18, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                check = 0;
            }

            if (x == "Se" || x == "se" || x == "سيلينيوم" || x == "34")
            {
                reader.SpeakAsync("Selenium");
              
                labelesm.Content = "سيلينيوم";//الاسم
                labelesm_Copy.Content = "34";//العدد
                labelesm_Copy1.Content = "Se";//الرمز
                labelesm_Copy2.Content = "لا فلز";//تصنيف العنصر
                labelesm_Copy9.Content = "78.96";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = " 4s^2 3d^10 4p^4";//توزيع الالكتروني 
                labelesm_Copy5.Content = "p";//المستوى الفرعي 
                labelesm_Copy6.Content = "16";//المجموعة
                labelesm_Copy7.Content = "4";//الدورة
                labelesm_Copy3.Content = "                6, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "se.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "La" || x == "la" || x == "لانثانوم" || x == "57")
            {
                reader.SpeakAsync("Lanthanum");
             
                labelesm.Content = "لانثانوم";//الاسم
                labelesm_Copy.Content = "57";//العدد
                labelesm_Copy1.Content = "La";//الرمز
                labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "138.90547";// الكتلة الذرية
                labelesm_Copy4.Content = "5d^1 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "     2 , 9, 18, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "la.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Bk" || x == "bk" || x == "بركيليوم" || x == "97")
            {
                reader.SpeakAsync("Berkelium");
      
                labelesm.Content = "بركيليوم";//الاسم
                labelesm_Copy.Content = "97";//العدد
                labelesm_Copy1.Content = "Bk";//الرمز
                labelesm_Copy2.Content = "أكتينيدات";//تصنيف العنصر
                labelesm_Copy9.Content = "247";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = "5f^9 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2, 8, 27, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Pa" || x == "pa" || x == "بروتكتينيوم" || x == "91")
            {
                reader.SpeakAsync("Protactinium");
          
                labelesm.Content = "بروتكتينيوم";//الاسم
                labelesm_Copy.Content = "91";//العدد
                labelesm_Copy1.Content = "Pa";//الرمز
                labelesm_Copy2.Content = "أكتينيدات";//تصنيف العنصر
                labelesm_Copy9.Content = "231.03588";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = " 7s^2 6d^1 5f^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2, 9, 20, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Pu" || x == "pu" || x == "بلوتونيوم" || x == "94")
            {
                reader.SpeakAsync("Plutonium");
          
                labelesm.Content = "بلوتونيوم";//الاسم
                labelesm_Copy.Content = "94";//العدد
                labelesm_Copy1.Content = "Pu";//الرمز
                labelesm_Copy2.Content = "أكتينيدات";//تصنيف العنصر
                labelesm_Copy9.Content = "244";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = "5f^6 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2, 8, 24, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "pu.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Lu" || x == "lu" || x == "لوتيشيوم" || x == "71")
            {
                reader.SpeakAsync("Lutetium");
              
                labelesm.Content = "لوتيشيوم";//الاسم
                labelesm_Copy.Content = "71";//العدد
                labelesm_Copy1.Content = "Lu";//الرمز
                labelesm_Copy2.Content = "أكتينيدات";//تصنيف العنصر
                labelesm_Copy9.Content = "174.9668";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = " 6s^2 4f^14 5d^1";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "    2, 9, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "lu.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Tb" || x == "tb" || x == "تيربيوم" || x == "65")
            {
                reader.SpeakAsync("Terbium");
      
                labelesm.Content = "تيربيوم";//الاسم
                labelesm_Copy.Content = "65";//العدد
                labelesm_Copy1.Content = "Tb";//الرمز
                labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
                labelesm_Copy9.Content = "158.92535";// الكتلة الذرية
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy4.Content = " 4f^9 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "    2, 8, 27, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "tb.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Th" || x == "th" || x == "ثوريوم" || x == "90")
            {
                reader.SpeakAsync("Thorium");
            
                labelesm.Content = "ثوريوم";//الاسم
                labelesm_Copy.Content = "90";//العدد
                labelesm_Copy1.Content = "Th";//الرمز
                labelesm_Copy2.Content = "أكتينيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "232.0381";// الكتلة الذرية
                labelesm_Copy4.Content = "6d^2 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2, 10, 18, 32, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Tm" || x == "tm" || x == "ثوليوم" || x == "69")
            {
                reader.SpeakAsync("Thulium");
              
                labelesm.Content = "ثوليوم";//الاسم
                labelesm_Copy.Content = "69";//العدد
                labelesm_Copy1.Content = "Tm";//الرمز
                labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "168.93421";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^13 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "    2, 8, 31, 18, 8, 2 ";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "tm.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Er" || x == "er" || x == "إربيوم" || x == "68")
            {
                reader.SpeakAsync("Erbium");
     
                labelesm.Content = "إربيوم";//الاسم
                labelesm_Copy.Content = "68";//العدد
                labelesm_Copy1.Content = "Er";//الرمز
                labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "167.259";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^12 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "     2 , 8, 30, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "er.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Sm" || x == "sm" || x == "ساماريوم" || x == "62")
            {
                reader.SpeakAsync("Samarium");
               
                labelesm.Content = "ساماريوم";//الاسم
                labelesm_Copy.Content = "62";//العدد
                labelesm_Copy1.Content = "Sm";//الرمز
                labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "150.36";// الكتلة الذرية
                labelesm_Copy4.Content = " 6s^2 4f^6";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "     2, 8, 24, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "sm.jpg", UriKind.Relative));
                check = 0;
            }



            if (x == "Eu" || x == "eu" || x == "يوروبيوم" || x == "63")
            {
                reader.SpeakAsync("Europium");
         
                labelesm.Content = "يوروبيوم";//الاسم
                labelesm_Copy.Content = "63";//العدد
                labelesm_Copy1.Content = "Eu";//الرمز
                labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "151.964";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^7 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "    2, 8, 25, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Ho" || x == "ho" || x == "هولميوم" || x == "67")
            {
                reader.SpeakAsync("Holmium");
             
                labelesm.Content = "هولميوم";//الاسم
                labelesm_Copy.Content = "67";//العدد
                labelesm_Copy1.Content = "Ho";//الرمز
                labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "164.93032";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^7 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "       2, 8, 29, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ho.jpg", UriKind.Relative));

                check = 0;
            }

            if (x == "Lr" || x == "lr" || x == "لورنسيوم" || x == "103")
            {
                reader.SpeakAsync("Lawrencium");
     
                labelesm.Content = "لورنسيوم";//الاسم
                labelesm_Copy.Content = "103";//العدد
                labelesm_Copy1.Content = "Lr";//الرمز
                labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "262";// الكتلة الذرية
                labelesm_Copy4.Content = " 5f^14 6d^1 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "d";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2 , 9, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "No" || x == "no" || x == "نوبليوم" || x == "102")
            {
                reader.SpeakAsync("Nobelium");
           
                labelesm.Content = "نوبليوم";//الاسم
                labelesm_Copy.Content = "102";//العدد
                labelesm_Copy1.Content = "No";//الرمز
                labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "259";// الكتلة الذرية
                labelesm_Copy4.Content = "5f^14 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2 , 8, 32, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Md" || x == "md" || x == "مندليفيوم" || x == "101")
            {
                reader.SpeakAsync("Mendelevium");
     
                labelesm.Content = "مندليفيوم";//الاسم
                labelesm_Copy.Content = "101";//العدد
                labelesm_Copy1.Content = "Md";//الرمز
                labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "258";// الكتلة الذرية
                labelesm_Copy4.Content = "5f^13 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2 , 8, 31, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Fm" || x == "fm" || x == "فرميوم" || x == "100")
            {
                reader.SpeakAsync("Fermium");
          
                labelesm.Content = "فرميوم";//الاسم
                labelesm_Copy.Content = "100";//العدد
                labelesm_Copy1.Content = "Fm";//الرمز
                labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "257";// الكتلة الذرية
                labelesm_Copy4.Content = "5f^12 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2 , 8, 30, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Es" || x == "es" || x == "أينشتاينيوم" || x == "99")
            {
                reader.SpeakAsync("Einsteinium");
     
                labelesm.Content = "أينشتاينيوم";//الاسم
                labelesm_Copy.Content = "99";//العدد
                labelesm_Copy1.Content = "Es";//الرمز
                labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "252";// الكتلة الذرية
                labelesm_Copy4.Content = "5f^11 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2 , 8, 29, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Cf" || x == "cf" || x == "كاليفورنيوم" || x == "98")
            {
                reader.SpeakAsync("Californium");
      
                labelesm.Content = "كاليفورنيوم";//الاسم
                labelesm_Copy.Content = "98";//العدد
                labelesm_Copy1.Content = "Cf";//الرمز
                labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "251";// الكتلة الذرية
                labelesm_Copy4.Content = "5f^10 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "   2 , 8, 28, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Cm" || x == "cm" || x == "كوريوم" || x == "96")
            {
                reader.SpeakAsync("Curium");
       

                labelesm.Content = "كوريوم";//الاسم
                labelesm_Copy.Content = "96";//العدد
                labelesm_Copy1.Content = "Cm";//الرمز
                labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "247";// الكتلة الذرية
                labelesm_Copy4.Content = "5f^7 6d^1 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2 , 8, 25, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Am" || x == "am" || x == "أمريسيوم" || x == "95")
            {
                reader.SpeakAsync("Americium");
        
                labelesm.Content = "أمريسيوم";//الاسم
                labelesm_Copy.Content = "95";//العدد
                labelesm_Copy1.Content = "Am";//الرمز
                labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "243";// الكتلة الذرية
                labelesm_Copy4.Content = " 5f^7 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2 , 8, 25, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "am.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Np" || x == "np" || x == "نبتونيوم" || x == "93")
            {
                reader.SpeakAsync("Neptunium");
         
                labelesm.Content = "نبتونيوم";//الاسم
                labelesm_Copy.Content = "93";//العدد
                labelesm_Copy1.Content = "Np";//الرمز
                labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "237";// الكتلة الذرية
                labelesm_Copy4.Content = "7s^2 6d^1 5f^4";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2 , 9, 22, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "np.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "U" || x == "u" || x == "يورانيوم" || x == "92")
            {
                reader.SpeakAsync("Uranium");
               
                labelesm.Content = "يورانيوم";//الاسم
                labelesm_Copy.Content = "92";//العدد
                labelesm_Copy1.Content = "U";//الرمز
                labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "238.02891";// الكتلة الذرية
                labelesm_Copy4.Content = " 5f^3 6d^1 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "2 , 9, 21, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "u.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Ac" || x == "ac" || x == "أكتينيوم" || x == "89")
            {
                reader.SpeakAsync("Actinium");
             
                labelesm.Content = "أكتينيوم";//الاسم
                labelesm_Copy.Content = "89";//العدد
                labelesm_Copy1.Content = "Ac";//الرمز
                labelesm_Copy2.Content = " أكتينيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "227";// الكتلة الذرية
                labelesm_Copy4.Content = "6d^1 7s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "7";//الدورة
                labelesm_Copy3.Content = "   2 , 9, 18, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Ce" || x == "ce" || x == "سيريوم" || x == "58")
            {
                reader.SpeakAsync("Cerium");
               
                labelesm.Content = "سيريوم";//الاسم
                labelesm_Copy.Content = "58";//العدد
                labelesm_Copy1.Content = "Ce";//الرمز
                labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "140.116";// الكتلة الذرية
                labelesm_Copy4.Content = "4f 5d 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "    2 , 9, 19, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "ce.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Pr" || x == "pr" || x == "براسوديميوم" || x == "59")
            {
                reader.SpeakAsync("Praseodymium");
              
                labelesm.Content = "براسوديميوم";//الاسم
                labelesm_Copy.Content = "59";//العدد
                labelesm_Copy1.Content = "Pr";//الرمز
                labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "140.90765";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^3 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "    2 , 8, 21, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "pr.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Nd" || x == "nd" || x == "نيوديميوم" || x == "60")
            {
                reader.SpeakAsync("Neodymium");
        
                labelesm.Content = "نيوديميوم";//الاسم
                labelesm_Copy.Content = "60";//العدد
                labelesm_Copy1.Content = "Nd";//الرمز
                labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "144.242";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^4 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "    2 , 8, 22, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nd.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Pm" || x == "pm" || x == "بروميثيوم" || x == "61")
            {
                reader.SpeakAsync("Promethium");
               
                labelesm.Content = "بروميثيوم";//الاسم
                labelesm_Copy.Content = "61";//العدد
                labelesm_Copy1.Content = "Pm";//الرمز
                labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "145";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^5 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "    2 , 8, 23, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "nopic.png", UriKind.Relative));
                check = 0;
            }

            if (x == "Gd" || x == "gd" || x == "غادولينيوم" || x == "64")
            {

                reader.SpeakAsync("Gadolinium");
          
                labelesm.Content = "غادولينيوم";//الاسم
                labelesm_Copy.Content = "64";//العدد
                labelesm_Copy1.Content = "Gd";//الرمز
                labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "157.25";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^7 5d^1 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "    2 , 9, 25, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "gd.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Dy" || x == "dy" || x == "ديسبروسيوم" || x == "66")
            {
                reader.SpeakAsync("Dysprosium");
       
                labelesm.Content = "ديسبروسيوم";//الاسم
                labelesm_Copy.Content = "66";//العدد
                labelesm_Copy1.Content = "Dy";//الرمز
                labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "162.500";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^10 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "    2 , 8, 28, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "dy.jpg", UriKind.Relative));
                check = 0;
            }

            if (x == "Yb" || x == "yb" || x == "إتيربيوم" || x == "70")
            {
                reader.SpeakAsync("Ytterbium");
            
                labelesm.Content = "إتيربيوم";//الاسم
                labelesm_Copy.Content = "70";//العدد
                labelesm_Copy1.Content = "Yb";//الرمز
                labelesm_Copy2.Content = "لانثانيدات";//تصنيف العنصر
                labelesm_Copy8.Content = "1-^غ·مول";
                labelesm_Copy9.Content = "173.054";// الكتلة الذرية
                labelesm_Copy4.Content = "4f^14 6s^2";//توزيع الالكتروني 
                labelesm_Copy5.Content = "f";//المستوى الفرعي 
                labelesm_Copy6.Content = "n/a";//المجموعة
                labelesm_Copy7.Content = "6";//الدورة
                labelesm_Copy3.Content = "    2 , 8, 32, 18, 8, 2";// توزيع الالكترون لكل غلاف 
                System.IO.FileInfo info = new System.IO.FileInfo("../../elements");
                ImageBrush.ImageSource = new BitmapImage(new Uri(info.FullName + "\\" + "yb.jpg", UriKind.Relative));
                check = 0;
            }
            if (check == 1)
            {
                MessageBox.Show("  لا يوجد هذا العنصر أو أن الرقم لا يوجد بين 1 - 116 أو أنك أضفت(الـ ) أو مسافات الى اسم العنصر  ");
            }
        }
    }
}
