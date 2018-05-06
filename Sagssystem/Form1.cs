using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;                                        // File Read & Write & StringWriter
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization.Formatters.Binary;   // Serialization

namespace Sagssystem
{
    public partial class HomeBase : Form
    {
        Microsoft.Win32.RegistryKey rk;
        private string lastFile = "";

        private string outputXMLFile = "";
        private string inputXMLFile = "";

        private enum Niveau { Projekt, Sag, OBS };
        private Niveau detteNiveau = Niveau.Projekt;
        private Projekt detteProjekt;
        private Sag denneSag;
        private Obs denneOBS;
        private SagSystemClass detteSagsSystem = new SagSystemClass();
        private List<Projekt> alleProjekter = new List<Projekt>();
        private List<Sag> alleSager = new List<Sag>();
        private List<Obs> alleOBSer = new List<Obs>();

        public HomeBase()
        {
            InitializeComponent();
            InitializeSagsSystem();
        }

        private void InitializeSagsSystem()
        {
            var niveauer = (Niveau[])Enum.GetValues(typeof(Niveau));
            foreach (Niveau niveau in niveauer)
            {
                niveauComboBox.Items.Add(niveau);
            }

            var statuser = (StatusClass.Status[])Enum.GetValues(typeof(StatusClass.Status));
            foreach (StatusClass.Status status in statuser)
            {
                statusComboBox.Items.Add(status);
            }
            statusComboBox.SelectedItem = StatusClass.Status.Oprettet;

            detteSagsSystem.projekter = alleProjekter;
            detteSagsSystem.sager = alleSager;
            detteSagsSystem.obser = alleOBSer;
        }

        private void søgBtn_Click(object sender, EventArgs e)
        {
            int søgteID;
            int.TryParse(SøgTextBox.Text,out søgteID);
            if (søgteID > 0)
            {
                switch (niveauComboBox.SelectedItem)
                {
                    case Niveau.OBS:
                        Obs søgteOBS = findObs(søgteID);
                        if(søgteOBS.ID>0)
                            obsTilSkærm(søgteOBS);
                        break;

                    case Niveau.Sag:
                        Sag søgteSag = findSag(søgteID);
                        if(søgteSag.ID>0)
                            sagTilSkærm(søgteSag);
                        break;

                    case Niveau.Projekt:
                        Projekt søgteProjekt = findProjekt(søgteID);
                        if(søgteProjekt.ID>0)
                            projektTilSkærm(søgteProjekt);
                        break;
                }
            }
        }

        private void gemBtn_Click(object sender, EventArgs e)
        {
            switch (detteNiveau)
            {
                case Niveau.OBS:
                    gemObs(denneOBS);
                    break;

                case Niveau.Sag:
                    gemSag(denneSag);
                    break;

                case Niveau.Projekt:
                    gemProjekt(detteProjekt);
                    break;
            }

            GemMenuItem_Click(sender, e);
        }

        private void nytProjektMenuItem_Click(object sender, EventArgs e)
        {
            Projekt nytProjekt = new Projekt(getNytProjektID());
            alleProjekter.Add(nytProjekt);
            detteProjekt = nytProjekt;
            detteNiveau = Niveau.Projekt;

            nytProjekt.RegistreretAf = "Bruger";
            nytProjekt.Status = StatusClass.Status.Oprettet;
            nytProjekt.Tester = nytProjekt.RegistreretAf;
            nytProjekt.Afventer = nytProjekt.RegistreretAf;
            nytProjekt.Ansvarlig = nytProjekt.RegistreretAf;
            nytProjekt.Kontakt = nytProjekt.RegistreretAf;
            nytProjekt.Ressource = nytProjekt.RegistreretAf;
        
            projektTilSkærm(nytProjekt);
        }

        private void nySagMenuItem_Click(object sender, EventArgs e)
        {
            Sag nySag = new Sag(GetNySagID());
            alleSager.Add(nySag);
            denneSag = nySag;
            detteNiveau = Niveau.Sag;

            nySag.RegistreretAf = detteProjekt.RegistreretAf;
            nySag.TilhørerProjekt = detteProjekt.ID;
            nySag.Status = StatusClass.Status.Oprettet;
            nySag.Tester = detteProjekt.Tester;
            nySag.Afventer = nySag.RegistreretAf;
            nySag.Ansvarlig = detteProjekt.Ansvarlig;
            nySag.Kontakt = detteProjekt.Kontakt;
            nySag.Ressource = detteProjekt.Kontakt;
            nySag.BeskrivelseKort = detteProjekt.BeskrivelseKort;
            nySag.BeskrivelseLang = detteProjekt.BeskrivelseLang;

            sagTilSkærm(nySag);
        }

        private void nyOBSMenuItem_Click(object sender, EventArgs e)
        {
            Obs nyObs = new Obs(getNyObsID());
            alleOBSer.Add(nyObs);
            denneOBS = nyObs;
            detteNiveau = Niveau.OBS;

            nyObs.RegistreretAf = denneSag.RegistreretAf;
            nyObs.TilhørerSag = denneSag.ID;
            nyObs.Status = StatusClass.Status.Oprettet;
            nyObs.Tester = denneSag.Tester;
            nyObs.Afventer = nyObs.RegistreretAf;
            nyObs.Ansvarlig = denneSag.Ansvarlig;
            nyObs.Kontakt = denneSag.Kontakt;
            nyObs.Ressource = nyObs.RegistreretAf;

            obsTilSkærm(nyObs);
        }

        private void gemProjekt(Projekt gemP)
        {
            niveauComboBox.SelectedItem = Niveau.Projekt.ToString();
            gemP.RegistreretAf= registreretTextBox.Text;
            parrentLbl.Enabled = false;
            parentTextBox.Enabled = false;
            gemP.Status = statusComboBox.SelectedItem; 
            gemP.Tester = testerTextBox.Text;
            gemP.Afventer= afventerLbl.Text;
            gemP.Ansvarlig = AnsvarligTextBox.Text;
            gemP.Kontakt = kontaktTextBox.Text;
            gemP.Ressource = ressourceTextBox.Text;
            gemP.BeskrivelseKort = kortBeskrivTextBox.Text;
            gemP.BeskrivelseLang = langBeskrivTextBox.Text;
        }

        private void projektTilSkærm(Projekt visProjekt)
        {
            niveauComboBox.SelectedItem = Niveau.Projekt;
            detteProjekt = visProjekt;
            detteNiveau = Niveau.Projekt;

            typeLbl.Text = "Projekt nr.:";
            rapNrLbl.Text = visProjekt.ID.ToString();
            registreretTextBox.Text = visProjekt.RegistreretAf;
            parrentLbl.Enabled = false;
            parentTextBox.Enabled = false;
            parentTextBox.Text = "";
            statusComboBox.SelectedItem = visProjekt.Status;
            testerTextBox.Text = visProjekt.Tester;
            afventerLbl.Text= visProjekt.Afventer;
            registreretTextBox.Text = visProjekt.RegistreretAf;
            regDatoLbl.Text = visProjekt.RegistreringsDatoTid.ToString();
            AnsvarligTextBox.Text= visProjekt.Ansvarlig;
            kontaktTextBox.Text = visProjekt.Kontakt;
            ressourceTextBox.Text= visProjekt.Ressource;
            kortBeskrivTextBox.Text= visProjekt.BeskrivelseKort;
            langBeskrivTextBox.Text = visProjekt.BeskrivelseLang;

            SøgTextBox.Text = visProjekt.ID.ToString();

            VisSagerUnderProjektIOversigt();
        }

        private void gemSag(Sag gemS)
        {
            niveauComboBox.SelectedItem = Niveau.Sag;
            gemS.RegistreretAf = registreretTextBox.Text;
            int.TryParse(parentTextBox.Text,out gemS.TilhørerProjekt);
            gemS.Status = statusComboBox.SelectedItem;
            gemS.Tester = testerTextBox.Text;
            gemS.Ansvarlig = AnsvarligTextBox.Text;
            gemS.Kontakt = kontaktTextBox.Text;
            gemS.Ressource = ressourceTextBox.Text;
            gemS.BeskrivelseKort = kortBeskrivTextBox.Text;
            gemS.BeskrivelseLang = langBeskrivTextBox.Text;

        }

        private void sagTilSkærm(Sag visSag)
        {
            niveauComboBox.SelectedItem = Niveau.Sag;
            detteNiveau = Niveau.Sag;
            denneSag = visSag;
            detteProjekt = findProjekt(denneSag.TilhørerProjekt);

            typeLbl.Text = "Sag nr.:";
            rapNrLbl.Text = visSag.ID.ToString();
            registreretTextBox.Text = visSag.RegistreretAf;
            regDatoLbl.Text = visSag.RegistreringsDatoTid.ToString();
            parrentLbl.Enabled = true;
            parrentLbl.Text = "Tilhører projekt:";
            parentTextBox.Enabled = true;
            parentTextBox.Text = visSag.TilhørerProjekt.ToString();
            statusComboBox.SelectedItem = visSag.Status;
            testerTextBox.Text = visSag.Tester;
            afventerLbl.Text = visSag.Afventer;
            AnsvarligTextBox.Text = visSag.Ansvarlig;
            kontaktTextBox.Text = visSag.Kontakt;
            ressourceTextBox.Text = visSag.Ressource;
            kortBeskrivTextBox.Text = visSag.BeskrivelseKort;
            langBeskrivTextBox.Text = visSag.BeskrivelseLang;

            SøgTextBox.Text = visSag.ID.ToString();

            VisObserUnderSagIOversigt();
        }

        private void gemObs(Obs gemO)
        {
            niveauComboBox.SelectedItem = Niveau.OBS;
            int.TryParse( parentTextBox.Text, out gemO.TilhørerSag);
            gemO.Status = statusComboBox.SelectedItem;
            gemO.Tester = testerTextBox.Text;
            gemO.Afventer = afventerLbl.Text;
            gemO.Ansvarlig = AnsvarligTextBox.Text;
            gemO.Kontakt = kontaktTextBox.Text;
            gemO.Ressource = ressourceTextBox.Text;
            gemO.BeskrivelseKort = kortBeskrivTextBox.Text;
            gemO.BeskrivelseLang = langBeskrivTextBox.Text;
        }

        private void obsTilSkærm(Obs visObs)
        {
            niveauComboBox.SelectedItem = Niveau.OBS;
            detteNiveau = Niveau.OBS;
            denneOBS = visObs;
            denneSag = findSag(denneOBS.TilhørerSag);
            detteProjekt = findProjekt(denneSag.TilhørerProjekt);

            typeLbl.Text = "Obsrapport nr.:";
            rapNrLbl.Text = visObs.ID.ToString();
            registreretTextBox.Text = visObs.RegistreretAf;
            regDatoLbl.Text = visObs.RegistreringsDatoTid.ToString();
            parrentLbl.Enabled = true;
            parrentLbl.Text = "Tilhører sag:";
            parentTextBox.Enabled = true;
            parentTextBox.Text = visObs.TilhørerSag.ToString();
            statusComboBox.SelectedItem = visObs.Status;
            testerTextBox.Text = visObs.Tester;
            afventerLbl.Text= visObs.Afventer;
            AnsvarligTextBox.Text=visObs.Ansvarlig;
            kontaktTextBox.Text= visObs.Kontakt;
            ressourceTextBox.Text= visObs.Ressource;
            kortBeskrivTextBox.Text=visObs.BeskrivelseKort;
            langBeskrivTextBox.Text = visObs.BeskrivelseLang;

            SøgTextBox.Text = visObs.ID.ToString();

            subTaskLbl.Visible = false;
            subTaskListView.Enabled = false;
            subTaskListView.Visible = false;
        }

        private Projekt findProjekt(int søgtID)
        {
            foreach(Projekt p in alleProjekter)
            {
                if (p.ID == søgtID) return p;
            }
            Projekt P0 = new Projekt();
            return P0;
        }

        private Sag findSag(int søgtID)
        {
            foreach(Sag s in alleSager)
            {
                if (s.ID == søgtID) return s;
            }
            Sag S0 = new Sag();
            return S0;
        }

        private Obs findObs(int søgtID)
        {
            foreach(Obs o in alleOBSer)
            {
                if (o.ID == søgtID) return o;
            }
            Obs O0 = new Obs();
            return O0;
        }

        private int getNytProjektID()
        {
            return getMaxProjektID() + 1;
        }

        private int GetNySagID()
        {
            return getMaxSagID() + 1;
        }

        private int getNyObsID()
        {
            return getMaxObsID() + 1;
        }

        private int getMaxProjektID()
        {
            int maxProjektID = 0;
            foreach(Projekt p in alleProjekter)
            {
                if (p.ID > maxProjektID) maxProjektID = p.ID;
            }

            return maxProjektID;
        }

        private int getMaxSagID()
        {
            int maxSagID = 0;
            foreach(Sag s in alleSager)
            {
                if (s.ID > maxSagID) maxSagID = s.ID;
            }

            return maxSagID;
        }

        private int getMaxObsID()
        {
            int maxObsID = 0;
            foreach(Obs o in alleOBSer)
            {
                if (o.ID > maxObsID) maxObsID = o.ID;
            }

            return maxObsID;
        }

        private void parrentLbl_click(object sender, EventArgs e)
        {
            switch(detteNiveau)
            {
                case Niveau.OBS:
                    niveauComboBox.SelectedItem = Niveau.Sag;
                    SøgTextBox.Text = denneOBS.TilhørerSag.ToString();
                    søgBtn_Click(sender, e);
                    break;

                case Niveau.Sag:
                    niveauComboBox.SelectedItem = Niveau.Projekt;
                    SøgTextBox.Text = denneSag.TilhørerProjekt.ToString();
                    søgBtn_Click(sender, e);
                    break;

                case Niveau.Projekt:
                    MessageBox.Show("Der er ikke noget niveau over Projekt!");
                    break;
                    
            }
        }

        private void WriteFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, detteSagsSystem);
            lastFile = filename;
            fs.Close();
        }

        private void SaveFile()
        {
            // Prompte for file name and writes DataSet as XML.
            // Saves the file name in registry for later use.
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "SagsSystem Data (.ssy)|*.ssy|All Files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.FileName = (string)rk.GetValue("Lastfile");
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                rk.SetValue("Lastfile", dlg.FileName);
                WriteFile(dlg.FileName);
            }
        }

        private void TilRecord()
        {
            switch (detteNiveau)
            {
                case Niveau.OBS:
                    gemObs(denneOBS);
                    break;

                case Niveau.Sag:
                    gemSag(denneSag);
                    break;

                case Niveau.Projekt:
                    gemProjekt(detteProjekt);
                    break;
            }
        }

        private void GemMenuItem_Click(object sender, EventArgs e)
        {
            TilRecord();
            if (lastFile == null)
                SaveFile();
            else
                WriteFile(lastFile);
        }

        private void gemSomMenuItem_Click(object sender, EventArgs e)
        {
            TilRecord();
            SaveFile();
        }

        private void HomeBase_Load(object sender, EventArgs e)
        {
            rk = Microsoft.Win32.Registry.CurrentUser;
            rk = rk.CreateSubKey(@"Projekter\SagsSystem");

            lastFile = (string)rk.GetValue("Lastfile");
            try
            {
                FileStream fs = new FileStream( lastFile, FileMode.Open, FileAccess.Read, FileShare.None);
                BinaryFormatter bf = new BinaryFormatter();
                detteSagsSystem = (SagSystemClass)bf.Deserialize(fs);
                fs.Close();
                alleProjekter = detteSagsSystem.projekter;
                alleSager = detteSagsSystem.sager;
                alleOBSer = detteSagsSystem.obser;
                projektTilSkærm(findProjekt(1));
                SøgTextBox.Focus();        // Place cursor 
            }
            catch (Exception err)
            {
                MessageBox.Show("Cannot Read File: " + err.ToString(), "Read Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void åbnSagssystemMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SagsSystem data (.ssy)|*.ssy|All Files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.FileName = (string)rk.GetValue("Lastfile");
            if (dlg.FileName == null) dlg.FileName = "";
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                rk.SetValue("Lastfile", dlg.FileName);
                try
                {
                    FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                    BinaryFormatter bf = new BinaryFormatter();
                    detteSagsSystem = (SagSystemClass)bf.Deserialize(fs);
                    fs.Close();
                    alleProjekter = detteSagsSystem.projekter;
                    alleSager = detteSagsSystem.sager;
                    alleOBSer = detteSagsSystem.obser;
                    projektTilSkærm(findProjekt(1));
                    lastFile = dlg.FileName;
                    SøgTextBox.Focus();        // Place cursor 
                }
                catch (Exception err)
                {
                    MessageBox.Show("Cannot Read File: " + err.ToString(), "Read Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void rydAltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detteSagsSystem = new SagSystemClass();
            alleProjekter = new List<Projekt> { };
            detteSagsSystem.projekter = alleProjekter;
            alleSager = new List<Sag> { };
            detteSagsSystem.sager = alleSager;
            alleOBSer = new List<Obs> { };
            detteSagsSystem.obser = alleOBSer;

            Projekt nytProjekt = new Projekt(getNytProjektID());
            alleProjekter.Add(nytProjekt);
            detteProjekt = nytProjekt;
            detteNiveau = Niveau.Projekt;

            nytProjekt.RegistreretAf = "Bruger";
            nytProjekt.Status = StatusClass.Status.Oprettet;
            nytProjekt.Tester = nytProjekt.RegistreretAf;
            nytProjekt.Afventer = nytProjekt.RegistreretAf;
            nytProjekt.Ansvarlig = nytProjekt.RegistreretAf;
            nytProjekt.Kontakt = nytProjekt.RegistreretAf;
            nytProjekt.Ressource = nytProjekt.RegistreretAf;

            projektTilSkærm(nytProjekt);

        }

        private void tilTekstfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Textfiles (.txt)|*.txt|All Files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.FileName = outputXMLFile;
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                outputXMLFile = dlg.FileName;

                XmlDocument doc = new XmlDocument();
                XmlDocument proDoc = new XmlDocument();
                XmlDocument sagDoc = new XmlDocument();
                XmlDocument obsDoc = new XmlDocument();

                String projektXMLstr;
                String sagXMLstr;
                String obsXMLstr;
                
                StringWriter sw = new StringWriter();
                using(XmlWriter wr = XmlWriter.Create(sw,new XmlWriterSettings() { Indent = true }))
                {
                    wr.WriteStartDocument();
                    wr.WriteStartElement("Sagsystem");
                    wr.WriteEndElement();
                    wr.Flush();
                }
                doc.LoadXml(sw.ToString());

                foreach (Projekt p in alleProjekter)
                {
                    projektXMLstr = p.ToXML();
                    //proDoc = new XmlDocument();
                    proDoc.LoadXml(projektXMLstr);

                    foreach (Sag s in alleSager)
                    {
                        if (s.TilhørerProjekt == p.ID)
                        {
                            sagXMLstr = s.ToXML();
                            //sagDoc = new XmlDocument();
                            sagDoc.LoadXml(sagXMLstr);
                            foreach (Obs o in alleOBSer)
                            {
                                if (o.TilhørerSag == s.ID)
                                {
                                    obsXMLstr = o.ToXML();
                                    //obsDoc = new XmlDocument();
                                    obsDoc.LoadXml(obsXMLstr);
                                    XmlNode importObs = sagDoc.ImportNode(obsDoc.DocumentElement, true);
                                    sagDoc.DocumentElement.AppendChild(importObs);
                                }
                            }
                            XmlNode importSag = proDoc.ImportNode(sagDoc.DocumentElement, true);
                            proDoc.DocumentElement.AppendChild(importSag);
                        }
                    }
                    XmlNode importPro = doc.ImportNode(proDoc.DocumentElement, true);
                    doc.DocumentElement.AppendChild(importPro);
                }
                doc.Save(outputXMLFile);
            }
        }

        private void fraTekstfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "XMLfiles (.xml)|*.xml|Textfiles (.txt)|*.txt|All Files (*.*)|*.*";
            dlg.FilterIndex = 1;
            dlg.FileName = outputXMLFile;
            DialogResult result = dlg.ShowDialog();

            string xml;
            //if (result == DialogResult.OK)
            if (result != DialogResult.Cancel && dlg.FileName != "")
            {
                inputXMLFile = dlg.FileName;
                lastFile = null;

                rydAltToolStripMenuItem_Click(sender, e);

                try
                {
                    StreamReader sr = new StreamReader(inputXMLFile);
                    //xml = sr.ReadToEnd();
                    //langBeskrivTextBox.Text += xml;
                    //XmlDocument doc = new XmlDocument();
                    //doc.LoadXml(xml);
                    /*XmlNodeList nodes = doc.GetElementsByTagName("Projekt");

                    foreach(XmlNode node in nodes)
                    {
                        langBeskrivTextBox.Text += node.Value.ToString();
                    }*/
                    XDocument xDoc = XDocument.Load(sr);

                }
                catch (FileNotFoundException)
                {
                    // File is not found
                    MessageBox.Show("The file was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException)
                {
                    // You don't have acces to this file
                    MessageBox.Show("You don't have acces to this file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    // Some error!
                    MessageBox.Show("Something is not right!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void VisSagerUnderProjektIOversigt()
        {
            subTaskLbl.Text = "Sager under dette Projekt";
            subTaskLbl.Visible = true;

            var alleSagerUnderProjekt = detteSagsSystem.FindSagerUnderProjekt(detteProjekt.ID);

            subTaskListView.Items.Clear();
            foreach (Sag sag in alleSagerUnderProjekt)
            {
                subTaskListView.Items.Add(new ListViewItem(new string[] { sag.ID.ToString(), sag.BeskrivelseKort, sag.Status.ToString() }));
            }
            subTaskListView.Enabled = true;
            subTaskListView.Visible = true;
        }
    
        private void VisObserUnderSagIOversigt()
        {
            subTaskLbl.Text = "OBSer under denne Sag";
            subTaskLbl.Visible = true;

            var alleObserUnderSag = detteSagsSystem.FindObserUnderSag(denneSag.ID);

            subTaskListView.Items.Clear();
            foreach (Obs obs in alleObserUnderSag)
            {
                subTaskListView.Items.Add(new ListViewItem(new string[] { obs.ID.ToString(), obs.BeskrivelseKort, obs.Status.ToString() }));
            }
            subTaskListView.Enabled = true;
            subTaskListView.Visible = true;
        }

        private void OpdaterAfventerLbl(object sender, EventArgs e)
        {
            switch (statusComboBox.SelectedItem)
            {
                case StatusClass.Status.Oprettet:
                    afventerLbl.Text = AnsvarligTextBox.Text;
                    break;
                case StatusClass.Status.Allokeret:
                    afventerLbl.Text = ressourceTextBox.Text;
                    break;
                case StatusClass.Status.Igang:
                    afventerLbl.Text = ressourceTextBox.Text;
                    break;
                case StatusClass.Status.Egentest:
                    afventerLbl.Text = testerTextBox.Text;
                    break;
                case StatusClass.Status.Brugertest:
                    afventerLbl.Text = kontaktTextBox.Text;
                    break;
                case StatusClass.Status.Godkendt:
                    afventerLbl.Text = AnsvarligTextBox.Text;
                    break;
                case StatusClass.Status.Afsluttet:
                    afventerLbl.Text = "";
                    break;
            }
        }

        private void subTaskListView_DoubleClick(object sender, EventArgs e)
        {
            if (subTaskListView.SelectedItems.Count > 0)
            {
                switch (detteNiveau)
                {
                    case Niveau.Projekt:
                        niveauComboBox.Text = Niveau.Sag.ToString();
                        break;
                    case Niveau.Sag:
                        niveauComboBox.Text = Niveau.OBS.ToString();
                        break;
                }
                SøgTextBox.Text = subTaskListView.SelectedItems[0].Text;
                søgBtn_Click(sender, e);

            }
        }
    }

}
