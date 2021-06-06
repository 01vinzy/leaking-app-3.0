using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace leaks_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            

            
                InitializeComponent();
            

                var webRequest = System.Net.WebRequest.Create(@"http://www.glitchluxyt.com/richtextbox.txt");

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                var strContent = reader.ReadToEnd();
                string be = strContent;
                
                FlowDocument bearer = new FlowDocument();
                Run rttext = new Run(be);
                Paragraph myParagraph = new Paragraph();
                myParagraph.Inlines.Add(rttext);
                bearer.Blocks.Add(myParagraph);
                rt.Document = bearer;
            }

            var webRequest1 = System.Net.WebRequest.Create(@"http://www.glitchluxyt.com/head.txt");

            using (var response1 = webRequest1.GetResponse())
            using (var content1 = response1.GetResponseStream())
            using (var reader1 = new StreamReader(content1))
            {
                var strContent4 = reader1.ReadToEnd();
                string be4 = strContent4;
                this.Title = be4;
            }


            label1.Content = "welcome " + Environment.UserName;
            
        }

        private void rt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var client = new RestClient("https://account-public-service-prod.ol.epicgames.com/account/api/oauth/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Authorization", "basic ZWM2ODRiOGM2ODdmNDc5ZmFkZWEzY2IyYWQ4M2Y1YzY6ZTFmMzFjMjExZjI4NDEzMTg2MjYyZDM3YTEzZmM4NGQ=");
            request.AddParameter("grant_type", "client_credentials");
            IRestResponse response = client.Execute(request);
            FlowDocument bearer = new FlowDocument();
            Run rttext = new Run(response.Content);
            Paragraph myParagraph = new Paragraph();
            myParagraph.Inlines.Add(rttext);
            bearer.Blocks.Add(myParagraph);
            rt.Document = bearer;
            cheese.Content = response.Content;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (umatextbox.Text == "enter access token")
            {
                MessageBox.Show("you must enter a access token");
            }
            else
            {
                
                
                var client = new RestClient("https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/public/assets/v2/platform/Windows/namespace/fn/catalogItem/4fe75bbc5a674f4f9b356b5c90567da5/app/Fortnite/label/Live");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", "bearer " + umatextbox.Text);
                IRestResponse response = client.Execute(request);
                FlowDocument bearer = new FlowDocument();
                Run rttext = new Run(response.Content);
                Paragraph myParagraph = new Paragraph();
                myParagraph.Inlines.Add(rttext);
                bearer.Blocks.Add(myParagraph);
                rt.Document = bearer;
                cheese.Content = response.Content;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (umatextbox.Text == "enter access token")
            {
                MessageBox.Show("you must enter a access token");
            }
            else
            {
                var client = new RestClient("https://fortnite-public-service-prod11.ol.epicgames.com/fortnite/api/cloudstorage/system/");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", "bearer " + umatextbox.Text);
                IRestResponse response = client.Execute(request);
                FlowDocument bearer = new FlowDocument();
                Run rttext = new Run(response.Content);
                Paragraph myParagraph = new Paragraph();
                myParagraph.Inlines.Add(rttext);
                bearer.Blocks.Add(myParagraph);
                rt.Document = bearer;
                cheese.Content = response.Content;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (umatextbox.Text == "enter access token")
            {
                MessageBox.Show("you must enter a access token");
            }
            else
            {
                var client = new RestClient("https://lightswitch-public-service-prod06.ol.epicgames.com/lightswitch/api/service/bulk/status?serviceId=Fortnite");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", "bearer " + umatextbox.Text);
                IRestResponse response = client.Execute(request);
                FlowDocument bearer = new FlowDocument();
                Run rttext = new Run(response.Content);
                Paragraph myParagraph = new Paragraph();
                myParagraph.Inlines.Add(rttext);
                bearer.Blocks.Add(myParagraph);
                rt.Document = bearer;
                cheese.Content = response.Content;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (umatextbox.Text == "enter access token")
            {
                MessageBox.Show("you must enter a access token");
            }
            else
            {
                var webRequest6 = System.Net.WebRequest.Create(@"http://glitchluxyt.com/defaultgame.txt");

                using (var response6 = webRequest6.GetResponse())
                using (var content6 = response6.GetResponseStream())
                using (var reader6 = new StreamReader(content6))
                {
                    var strContent6 = reader6.ReadToEnd();
                    string be6 = strContent6;



                    var client = new RestClient("https://fortnite-public-service-prod11.ol.epicgames.com/fortnite/api/cloudstorage/system/" + be6);
                    client.Timeout = -1;
                    var request = new RestRequest(Method.GET);
                    request.AddHeader("Authorization", "bearer " + umatextbox.Text);
                    IRestResponse response = client.Execute(request);
                    FlowDocument bearer = new FlowDocument();
                    Run rttext = new Run(response.Content);
                    Paragraph myParagraph = new Paragraph();
                    myParagraph.Inlines.Add(rttext);
                    bearer.Blocks.Add(myParagraph);
                    rt.Document = bearer;
                    cheese.Content = response.Content;
                }
               
            }
        
            

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var webRequest6 = System.Net.WebRequest.Create(@"http://glitchluxyt.com/credits.txt");

            using (var response6 = webRequest6.GetResponse())
            using (var content6 = response6.GetResponseStream())
            using (var reader6 = new StreamReader(content6))
            {
                var strContent6 = reader6.ReadToEnd();
                string be6 = strContent6;
                FlowDocument bearer = new FlowDocument();
                Run rttext = new Run(strContent6);
                Paragraph myParagraph = new Paragraph();
                myParagraph.Inlines.Add(rttext);
                bearer.Blocks.Add(myParagraph);
                rt.Document = bearer;
                
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("data.json", @"<html><body>idk</body></html>");
            List<string> lines = new List<string>();
            lines.Add(Convert.ToString(cheese.Content));

            File.WriteAllLines("data.json", lines);

            File.WriteAllLines("data.json", lines.ToArray());
        }

        private void umatextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
