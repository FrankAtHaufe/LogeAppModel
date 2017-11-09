using System;
using NUnit.Framework;
using HP.LFT.SDK;
using HP.LFT.Verifications;
using LogeAppModel;
using HP.LFT.SDK.WinForms;
using HP.LFT.SDK.StdWin;
using System.Windows.Forms;
using HP.LFT.Common;
using System.Drawing;
using HP.LFT.Report;




namespace UnitTestsLogePro
{

    [TestFixture]
    public class LeanFtTest : UnitTestClassBase 

    {

        public void Hauptmenue(string Shortcut1, string Shortcut2, string Shortcut3)
        {
            ClassHauptmenue repository = new ClassHauptmenue();
            repository.LexwareProfessionalWindow.Activate();
            repository.LexwareProfessionalWindow.SendKeys(Shortcut1, KeyModifier.Alt);
            repository.LexwareProfessionalWindow.SendKeys(Shortcut2);
            repository.LexwareProfessionalWindow.SendKeys(Shortcut3);

            //Test
            //int a = repository.LexwareProfessionalWindow.WindowId;
            //string b = repository.LexwareProfessionalWindow.Text;
            //MessageBox.Show(a.ToString() + b);
        }

        public void FirmaSeite1(string Name, string Strasse, string Action)
        {
            ClassFirmaSeite1 repository = new ClassFirmaSeite1();

            
            bool ValidateExistance = repository.Firmenassistent.Exists(10);
            if (ValidateExistance == true)
            {
                Reporter.ReportEvent("Firmenassistent", "Firmenassistent wurde gefunden", Status.Passed);
            }
            else
            {
                Image snapshot = repository.Firmenassistent.GetSnapshot();
                Reporter.ReportEvent("Firmenassistent", "Firmenassistent wurde nicht gefunden", Status.Failed,snapshot);
                MessageBox.Show("Firmenassistent wurde nicht gefunden");
                Assert.IsTrue(false, "Firmenassistent nicht gefunden");
              
            }


            repository.Firmenassistent.NameEditField.SetText(Name);
            repository.Firmenassistent.StrasseEditField.SetText(Strasse);
            //Assert.AreEqual("meine Firma", repository.Firmenassistent.NameEditField.Text);
            repository.Firmenassistent.ActionButton.Description.Text = Action;
            repository.Firmenassistent.ActionButton.Click();
        }

    

        public void StandardDialog(string ButtonText)
        {
            ClassStandardDialog repository = new ClassStandardDialog();
            repository.StandardDialog.Activate();
            repository.StandardDialog.Button.Description.Text = ButtonText;
            repository.StandardDialog.Button.Click();
        }



        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            

        }

        [SetUp]
        public void SetUp()
        {
            // Before each test
        }

        
        public void FirmaAnlegen(string Firmenname) 
        {
                Hauptmenue("d", "n", "f");
                StandardDialog("OK");
                FirmaSeite1(Firmenname, "meine Strasse", "Abbrechen");
                StandardDialog("&Ja");
        }


        [Test]
        public void Smoketest()
        {
            FirmaAnlegen("Smoketestfirma");
        }





        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            // Clean up once per fixture
        }
    }
}
