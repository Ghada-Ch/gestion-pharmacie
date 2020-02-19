using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoucheDAO;
using CoucheDAO.Entities;
using System.Data.SqlClient;
using CoucheDAO.DAOImp;
using CoucheDAO.Connection;

namespace WindowsFormsApp3
{
    enum ModeApplicatif { MODEAJOUT, MODECONSULTATION, MODEMODIFICATION }
    enum ETATCONNECTION { connecter,deconnecter}
    public partial class Form1 : Form
    {
        List<Client> clients= new List<Client>();
        DAOImpClient DAO;
        DAOImpGammes DAOG;
        DAOImpInteret DAOI;
        DAOImpAutreG DAOAG;
        DAOImpAutreI DAOAI;
        DAOImpClientGamme DAOCG;
        DAOImpClientInteret DAOCI;
        ModeApplicatif _modeApplicatif;
        List<Gamme> gammes=new List<Gamme>();
        ETATCONNECTION _etatconnection;
        List<Interet> interets=new List<Interet>();

        public Form1()
        {

            InitializeComponent();
            FactoryConnection.GetConnection("Server=localhost;Database=gestion_para_pharma;User Id=root;Password= ;Convert Zero Datetime=True");
            DAOG = new DAOImpGammes();
            DAOI = new DAOImpInteret();
            DAO = new DAOImpClient();
            DAOAG = new DAOImpAutreG();
            DAOAI = new DAOImpAutreI();
            DAOCG = new DAOImpClientGamme();
            DAOCI = new DAOImpClientInteret();
            _etatconnection = ETATCONNECTION.connecter;
            clients = DAO.RecupererTousClient();
            interets = DAOI.RecupererTousInteret();
            gammes = DAOG.RecupererTousGamme();
            dglisteClients.DataSource =clients;
            AfficherGamme();
            AfficherInteret();
            ActiverModeconsultation();
            
        }

        void ActiverModeconsultation()
        {

            _modeApplicatif = ModeApplicatif.MODECONSULTATION;
            txtbCode.Enabled = false;
            txtbNom.Enabled = false;
            txtbPrenom.Enabled = false;
            txtbAdresse.Enabled = false;
            txtbTel.Enabled = false;
            dpikDateNaissance.Enabled = false;
            txtbCivilite.Enabled = false;
            txtbEmail.Enabled = false;
            txtbFacebook.Enabled = false;
            txtbRemarque.Enabled = false;
            gbGamme.Enabled = false;
            gbInteret.Enabled = false;

            butAjouter.Visible = true;
            butModifier.Visible = true;
            buSupprimer.Visible = true;
            dglisteClients.Enabled = true;
            butQuitter.Text = "Quitter";
            butConfirmer.Visible = false;
           
           
            
            
            dglisteClients.Refresh();
        }
        void ActiverModeAjout()
        {
            _modeApplicatif = ModeApplicatif.MODEAJOUT;
            txtbCode.Text = ""+DAO.getKey();
            txtbNom.Enabled = true;
            txtbPrenom.Enabled = true;
            txtbAdresse.Enabled = true;
            txtbTel.Enabled = true;
            dpikDateNaissance.Enabled = true;
            txtbCivilite.Enabled = true;
            txtbEmail.Enabled = true;
            txtbFacebook.Enabled = true;
            txtbRemarque.Enabled = true;
            gbGamme.Enabled = true;
            gbInteret.Enabled = true;

            txtbNom.Text= "";
            txtbPrenom.Text = "";
            txtbAdresse.Text = "";
            txtbTel.Text = "";
            dpikDateNaissance.Text = "";
            txtbCivilite.Text = "";
            txtbEmail.Text = "";
            txtbFacebook.Text = "";
            txtbRemarque.Text ="";
            checkedListGammes.ClearSelected();

            textbAutreGamme.Enabled = false;
            textbAutreInteret.Enabled = false;
            butAjouter.Visible = false;
            butModifier.Visible = false;
            buSupprimer.Visible = false;
            dglisteClients.Enabled = false;
            butQuitter.Text = "Annuler";
            butConfirmer.Visible = true;
            


        }

        void ActiverModeModification()
        {
            _modeApplicatif = ModeApplicatif.MODEMODIFICATION;
            txtbNom.Enabled = true;
            txtbPrenom.Enabled = true;
            txtbAdresse.Enabled = true;
            txtbTel.Enabled = true;
            dpikDateNaissance.Enabled = true;
            txtbCivilite.Enabled = true;
            txtbEmail.Enabled = true;
            txtbFacebook.Enabled = true;
            txtbRemarque.Enabled = true;
            gbGamme.Enabled = true;
            gbInteret.Enabled = true;

            textbAutreGamme.Enabled = false;
            textbAutreInteret.Enabled = false;
            butAjouter.Visible = false;
            butModifier.Visible = false;
            buSupprimer.Visible = false;
            dglisteClients.Enabled = false;
            butQuitter.Text = "Annuler";
            butConfirmer.Visible = true;
            
        }
        private void AfficherGamme()
        {
           
            try
            {

                for (int j = 0; j < gammes.Count - 1; j++)
                {
                    CheckBox check = new CheckBox();
                    check.Text = gammes[j].libelle;
                    check.Name = gammes[j].libelle;
                    checkedListGammes.Items.Add(check.Text);
                }
                CheckBox Autre = new CheckBox();
                Autre.Text = "Autre Gamme";
                Autre.Name = "AutreGamme";
                checkedListGammes.Items.Add(Autre.Text);


            }
            catch (Exception ex)
            {
                MessageBox.Show("No gamme"+ex);
            }
            
           
        }
       private void AfficherInteret()
        {
            try
            {

                     
                
                    for(int j=0;j<interets.Count -1;j++)
                    {
                     CheckBox check = new CheckBox();
                     check.Text = interets[j].libelle;
                     check.Name = interets[j].libelle;
                     checkedListInterets.Items.Add(check.Text);
                    }
                CheckBox Autre = new CheckBox();
               Autre.Text = "Autre Interet";
                Autre.Name = "AutreInteret";
                checkedListInterets.Items.Add(Autre.Text);


            }
            catch (Exception ex)
            {
                MessageBox.Show("No Interet"+ex.Message);
            }

        }

        private bool AskConfirmQuitAppli()
        {
            // message confirmation quitter l'application
            if (MessageBox.Show("Quitter ParaPharmacie?",
                               "Message de confirmation",
                               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // non
                return false;
            };

            // oui, quitter
            return true;
        }

        private void Quitter()
        {
            if (AskConfirmQuitAppli() == false)
                ActiverModeconsultation();
            else
            {
                FactoryConnection._con.Close();
                Close();

            }
               
        }
        private bool Validerchamps()
        {


            return true;
        }
        private int ModifierClient()
        {
            int  email = 0;
            int  sms = 0;
            if (checkBoxEmail.Checked)
                 email = 1;
            if (checkBoxSMS.Checked)
                sms = 1;
            int j=DAO.ModidierClient(Convert.ToInt32(txtbCode.Text), txtbNom.Text, txtbPrenom.Text, txtbCivilite.Text, dpikDateNaissance.Value, Convert.ToInt32(txtbTel.Text), txtbAdresse.Text, txtbEmail.Text, txtbFacebook.Text,txtbRemarque.Text,email,sms);
            AjouterGammeClient();
            
            AjouterInteretClient();
            clients = DAO.RecupererTousClient();
            dglisteClients.DataSource = clients;
            dglisteClients.Refresh();
            return j;
        }

        string AjouterNouveauClient()
        {
            String ch = null;
            string ch2 = null;
            int email = 0;
            int sms = 0;
            if (checkBoxEmail.Checked)
                email = 1;
            if (checkBoxSMS.Checked)
                sms = 1;
            try
            {
                ch=DAO.AjouterClient(txtbNom.Text, txtbPrenom.Text, txtbCivilite.Text, dpikDateNaissance.Value, Convert.ToInt32(txtbTel.Text), txtbAdresse.Text, txtbEmail.Text, txtbFacebook.Text,txtbRemarque.Text,email,sms);
                if (textbAutreGamme.Enabled)
                   ch2 =DAOAG.AjouterAutreGamme(textbAutreGamme.Text, Convert.ToInt32(txtbCode.Text));

                if (textbAutreInteret.Enabled)
                   DAOAI.AjouterAutreInteret(textbAutreInteret.Text, Convert.ToInt32(txtbCode.Text));
                AjouterGammeClient();
                AjouterInteretClient();
                clients = DAO.RecupererTousClient();
                dglisteClients.DataSource = clients;
                dglisteClients.Refresh();

            }
            catch(Exception e)
            {
                MessageBox.Show("Verifier les informations!"+e.Message);
            }
            return ch;
        }
        
        public void AjouterGammeClient()
        {
            for(int i=0; i<checkedListGammes.CheckedItems.Count;i++)
            {
               if((checkedListGammes.CheckedItems[i]).ToString() != "Autre Gamme")
                {
                    DAOCG.AjouterClientGamme((checkedListGammes.CheckedItems[i]).ToString(),Convert.ToInt32(txtbCode.Text)); 
                }

            }
        }
        public void AjouterInteretClient()
        {
            for (int i = 0; i < checkedListInterets.CheckedItems.Count; i++)
            {
                if((checkedListInterets.CheckedItems[i]).ToString() !="Autre Interet")
                {
                    DAOCI.AjouterClientInteret((checkedListInterets.CheckedItems[i]).ToString(), Convert.ToInt32(txtbCode.Text));
                }

            }
        }

        private bool AskConfirmSupp()
        {
            // message confirmation quitter l'application
            if (MessageBox.Show("Etes-vous sure de supprimer ce client?",
                               "Message de confirmation",
                               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // non
                return false;
            };

            // oui, quitter
            return true;
        }
        private void Supprimer(int code)
        {
            string ch=DAO.SupprimerClient(code);
           
            MessageBox.Show(ch);
            clients = DAO.RecupererTousClient();
            dglisteClients.DataSource = clients;
            dglisteClients.Refresh();
        }
       
        private void butConfirmer_Click(object sender, EventArgs e)
        {
            if (_etatconnection == ETATCONNECTION.connecter)

            { 
                try
                {
                    if(_modeApplicatif==ModeApplicatif.MODEAJOUT)
                    {
                        string ch = AjouterNouveauClient();
                        if (ch == null) MessageBox.Show("Client ajouté");
                        else MessageBox.Show("Problème d'insertion : "+ch);
                    }
                   
                    else
                    {

                        int j = ModifierClient();
                        if (j == 1) MessageBox.Show("Client Modifié");
                        else MessageBox.Show("Problème de Modification");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur d'ajout !" + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Connect before !");
            }
            ActiverModeconsultation();
        }
        
        

        private void butModifier_Click(object sender, EventArgs e)
        {
            ActiverModeModification();
        }

        private void butQuitter_Click_1(object sender, EventArgs e)
        {
            switch (_modeApplicatif)
            {
                case ModeApplicatif.MODEAJOUT: ActiverModeconsultation(); break;
                case ModeApplicatif.MODECONSULTATION: Quitter(); break;
                case ModeApplicatif.MODEMODIFICATION: ActiverModeconsultation(); break;

            }
        }

        private void dglisteClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbCode.Text = Convert.ToString(dglisteClients.CurrentRow.Cells[0].Value);
            txtbNom.Text = Convert.ToString(dglisteClients.CurrentRow.Cells[1].Value);
            txtbPrenom.Text = Convert.ToString(dglisteClients.CurrentRow.Cells[2].Value);
            txtbTel.Text = Convert.ToString(dglisteClients.CurrentRow.Cells[5].Value);
            txtbCivilite.Text = Convert.ToString(dglisteClients.CurrentRow.Cells[3].Value);
            txtbAdresse.Text = Convert.ToString(dglisteClients.CurrentRow.Cells[6].Value);
            txtbEmail.Text = Convert.ToString(dglisteClients.CurrentRow.Cells[7].Value);
            txtbFacebook.Text = Convert.ToString(dglisteClients.CurrentRow.Cells[8].Value);
            //dpikDateNaissance.Value = Convert.ToDateTime(dglisteClients.CurrentRow.Cells[4].Value);
            txtbRemarque.Text= Convert.ToString(dglisteClients.CurrentRow.Cells[9].Value);
        }

        private void butAjouter_Click(object sender, EventArgs e)
        {
            ActiverModeAjout();
        }
        private void buSupprimer_Click(object sender, EventArgs e)
        {
            if ((AskConfirmSupp() == true))
            {
                if (dglisteClients.CurrentRow.Cells[0].Value != null)
                {
                    int code = Convert.ToInt32(dglisteClients.CurrentRow.Cells[0].Value);
                    Supprimer(code);
                    clients = DAO.RecupererTousClient();
                    dglisteClients.Refresh();
                }
                else
                    MessageBox.Show("Champs vide");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Client[] _listClient = new Client[100];
                int cptRecherche = 0;
                int cpt = 0;
                while (cpt != clients.Count)
                {


                    if (clients[cpt].Codeclt.ToString().Contains(textBox1.Text))
                    {
                        _listClient[cptRecherche++] = clients[cpt];
                        cptRecherche++;
                    }


                    cpt++;
                }
                if (textBox1.Text == "")
                {
                    dglisteClients.DataSource = clients;
                }
                else
                    dglisteClients.DataSource = _listClient;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try { 
            Client[] _listClient = new Client[100];
            int cptRecherche = 0;
            int cpt = 0;
            while (cpt != clients.Count)
            {


                if (clients[cpt].Nomclt.ToString().Contains(textBox2.Text))
                    {
                        _listClient[cptRecherche++] = clients[cpt];
                        cptRecherche++;
                    }


                    cpt++;
            }
            if (textBox2.Text == "")
            {
                dglisteClients.DataSource=clients;
            }
            else
                dglisteClients.DataSource = _listClient;


        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

    }



private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Client[] _listClient = new Client[100];
                int cptRecherche = 0;
                int cpt = 0;
                while (cpt != clients.Count)
                {


                    if (clients[cpt].PrenomClt.ToString().Contains(textBox3.Text))
                    {
                        _listClient[cptRecherche++] = clients[cpt];
                        cptRecherche++;
                    }


                    cpt++;
                }
                if (textBox3.Text == "")
                {
                    dglisteClients.DataSource=clients;
                }
                else
                    dglisteClients.DataSource = _listClient;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkedListGammes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkedListGammes.GetItemChecked(gammes.Count-1))
            {
                textbAutreGamme.Enabled = true;
            }
            else 
            {
                textbAutreGamme.Enabled = false;
            }
        }

        private void checkedListInterets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListInterets.GetItemChecked(interets.Count-1 ))
            {
                textbAutreInteret.Enabled = true;
            }
            else
            {
                textbAutreInteret.Enabled = false;
            }
        }

        private void txtbTel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

