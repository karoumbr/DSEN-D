using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FnAgregation_DSEN_D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }






        public void remplirDataGridView()
        {
            dgvClients.Rows.Clear();

            OleDbConnection cn = new OleDbConnection();
            OleDbDataReader lect;

            cn = Global.seConnecter(Global.cs);
            lect = Global.ExecuterOleDBSelect(@"select * from clients", cn);
            while (lect.Read())
            {
                dgvClients.Rows.Add(lect.GetValue(0).ToString(), lect.GetValue(1).ToString(), lect.GetValue(2).ToString(), lect.GetValue(3).ToString());
            }

            Global.seDeconnecter(cn);
            lect.Close();

        }


        private void btnCountClients_Click(object sender, EventArgs e)
        {
            Object ob = new object();
            OleDbConnection cn;
          cn =   Global.seConnecter(Global.cs);
            ob = Global.ExecuterOleDbScalaire("select count(*) from clients", cn);
            Global.seDeconnecter(cn);
            txtCountClients.Text = ob.ToString();


        }

        private void btnMoyenneSoldes_Click(object sender, EventArgs e)
        {
            Object ob = new object();
            OleDbConnection cn;
            cn = Global.seConnecter(Global.cs);
            ob = Global.ExecuterOleDbScalaire("select avg(solde) from clients", cn);
            Global.seDeconnecter(cn);
            txtMoyenneSoldes.Text = ob.ToString();
        }

        private void btnSoldeMin_Click(object sender, EventArgs e)
        {
            Object ob = new object();
            OleDbConnection cn;
            cn = Global.seConnecter(Global.cs);
            ob = Global.ExecuterOleDbScalaire("select MIN(solde) from clients", cn);
            Global.seDeconnecter(cn);
            txtSoldeMin.Text = ob.ToString();
        }

        private void btnSoldeMax_Click(object sender, EventArgs e)
        {
            Object ob = new object();
            OleDbConnection cn;
            cn = Global.seConnecter(Global.cs);
            ob = Global.ExecuterOleDbScalaire("select MAX(solde) from clients", cn);
            Global.seDeconnecter(cn);
            txtSoldeMax.Text = ob.ToString();
        }

        private void btnSommeSoldes_Click(object sender, EventArgs e)
        {
            Object ob = new object();
            OleDbConnection cn;
            cn = Global.seConnecter(Global.cs);
            ob = Global.ExecuterOleDbScalaire("select sum(solde) from clients", cn);
            Global.seDeconnecter(cn);
            txtSommeSoldes.Text = ob.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            remplirDataGridView();
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            int res = 0;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
          res =   Global.ExecuterOleDBAction(@"insert into clients(nom,adresse,solde) values ('Nouveau client','Tunis',100.0)", cn);
            Global.seDeconnecter(cn);
            remplirDataGridView();
            MessageBox.Show(res.ToString());
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {

            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Sélectionnez la ligne entière." + "\n" + "Cliquez sur le curseur à gauche du datagrid.", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Voulez vous supprimer ce client?", "Confirmation de la suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                OleDbConnection cn = new OleDbConnection();
                cn = Global.seConnecter(Global.cs);
                Global.ExecuterOleDBAction(@"delete from clients where id = " + dgvClients.SelectedRows[0].Cells[0].Value.ToString(), cn);
                Global.seDeconnecter(cn);
                remplirDataGridView();
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
      

            OleDbConnection cn = new OleDbConnection();
            OleDbDataReader lect2;

            cn = Global.seConnecter(Global.cs);
            lect2 = Global.ExecuterOleDBSelect(@"select * from clients where id=" + txtIdClient.Text, cn);
            while (lect2.Read())
            {
                txtNom.Text = lect2.GetValue(1).ToString();
                txtAdresse.Text = lect2.GetValue(2).ToString();
                txtSolde.Text = lect2.GetValue(3).ToString();
       
            }

            Global.seDeconnecter(cn);
            lect2.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // troisième manière proposée par Houcem
                OleDbConnection conn = new OleDbConnection(Global.cs);
                 OleDbCommand cmd = conn.CreateCommand();
                 cmd.CommandText = "update clients set nom = @nom , adresse = @adr,solde = @solde where id = @id";
                 cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                 cmd.Parameters.AddWithValue("@adr", txtAdresse.Text);
                 cmd.Parameters.AddWithValue("@solde", txtSolde.Text);
                 cmd.Parameters.AddWithValue("@id",  txtIdClient.Text);
                 conn.Open();
                 cmd.ExecuteNonQuery();
                 conn.Close();
                remplirDataGridView();
                 MessageBox.Show("Success!");
            /* int res = 0;
             OleDbConnection cn = new OleDbConnection();
             cn = Global.seConnecter(Global.cs);
             //première méthode 
             //  res = Global.ExecuterOleDBAction(@"update  clients set nom='" + txtNom.Text + "',adresse='" + txtAdresse.Text + "',solde=" + txtSolde.Text + " where id="+ txtIdClient.Text, cn);
             // deuxième méthode
             Object[] tabPM = {txtNom.Text,txtAdresse.Text,txtSolde.Text,txtIdClient.Text }; 
             res = Global.ExecuterOleDBAction(@"update  clients set nom=?,adresse=?,solde=? where id=?", cn, tabPM);



             Global.seDeconnecter(cn);
             remplirDataGridView();
             MessageBox.Show(res.ToString());*/
        }

        private void btnTransfert_Click(object sender, EventArgs e)
        {

        }
    }
}
