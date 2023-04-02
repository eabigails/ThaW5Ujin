﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace thaujinshinchan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        DataTable category = new DataTable();
        DataTable filter = new DataTable();
        bool hlo = true;
        string choose = "";
        int count = 0;
        string oke = "";
        int cape = 0;
        string idproduct = "";
        string categoryprduk = "";
        public static List<string> Category = new List<string>() { "C1", "C2", "C3", "C4", "C5" };
        public static List<string> productname = new List<string>() { "Jas", "T-Shirt", "Rok", "Celana", "Cawat" };
        public int simpan = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID Product");
            dt.Columns.Add("Nama Product");
            dt.Columns.Add("Harga");
            dt.Columns.Add("Stock");
            dt.Columns.Add("ID\r\nCategory");
            dtProdukSimpan.DataSource = dt;
            dt.Rows.Add("J001", "Jas Hitam", 100000, 10, "C1");
            dt.Rows.Add("T001", "T - Shirt Black Pink", 70000, 20, "C2");
            dt.Rows.Add("T002", "T-Shirt Obsessive", 75000, 16, "C2");
            dt.Rows.Add("R001", "Rok mini", 82000, 26, "C3");
            dt.Rows.Add("J002", "Jeans Biru", 90000, 5, "C4");
            dt.Rows.Add("C001", "Celana Pendek Coklat", 60000, 11, "C4");
            dt.Rows.Add("C002", "Cawat Blink-blink", 1000000, 1, "C5");
            dt.Rows.Add("R002", "Rocca Shirt", 50000, 8, "C2");

            category.Columns.Add("ID Category");
            category.Columns.Add("Nama Category");
            category.Rows.Add("C1", "Jas");
            category.Rows.Add("C2", "T-Shirt");
            category.Rows.Add("C3", "Rok");
            category.Rows.Add("C4", "Celana");
            category.Rows.Add("C5", "Cawat");
            dtCategory.DataSource = category;

            filter.Columns.Add("ID Product");
            filter.Columns.Add("Nama Product");
            filter.Columns.Add("Harga");
            filter.Columns.Add("Stock");
            filter.Columns.Add("ID\r\nCategory");

            dtProdukSimpan.ClearSelection();
            dtCategory.ClearSelection();
            lelah();
            filterhahaha();
        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            if (txtbox_nama.Text == "" && txtbox_harga.Text == "" && txtbox_stock.Text == "" && cbox_category.SelectedItem == null)
            {
                MessageBox.Show("Error please input first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool check = false;
                string ID = txtbox_nama.Text.Substring(0, 1).ToUpper();
                int angka = 0;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (ID == dt.Rows[i][0].ToString()[0].ToString())
                    {
                        if (angka <= Convert.ToInt32(dt.Rows[i][0].ToString().Substring(1)))
                        {
                            angka = Convert.ToInt32(dt.Rows[i][0].ToString().Substring(1));
                        }
                    }
                }
                
                idproduct = ID;
                angka = angka + 1;
                for (int i = 0; i < 3 - angka.ToString().Length; i++)
                {
                    idproduct += "0";
                }
                idproduct += angka;
                

                for (int i = 0; i < category.Rows.Count; i++)
                {
                    if (cbox_category.SelectedItem.ToString() == category.Rows[i][1].ToString())
                    {
                        categoryprduk = category.Rows[i][0].ToString();
                    }
                }

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() == txtbox_nama.Text)
                    {
                        check = true;
                    }
                }

                if (check == false)
                {
                    dt.Rows.Add(idproduct, txtbox_nama.Text, txtbox_harga.Text, txtbox_stock.Text, categoryprduk);

                    txtbox_nama.Clear();
                    txtbox_harga.Clear();
                    txtbox_stock.Clear();
                }
                else
                {
                    MessageBox.Show("Product already input", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        
       

        private void tb_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
        private void btn_removeproduct_Click(object sender, EventArgs e)
        {
            if (dtProdukSimpan.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Error please input first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dtProdukSimpan.Rows.RemoveAt(dtProdukSimpan.CurrentCell.RowIndex);
            }
        }

       

        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string simpan = "";
            filter.Rows.Clear();
            for (int a = 0; a < category.Rows.Count; a++)
            {
                if (cbox_filter.Text == category.Rows[a][1].ToString())
                {
                    simpan = category.Rows[a][0].ToString();
                }
            }
            for (int b = 0; b < dt.Rows.Count; b++)
            {
                if (simpan == dt.Rows[b][4].ToString())
                {
                    filter.Rows.Add(dt.Rows[b][0], dt.Rows[b][1], dt.Rows[b][2], dt.Rows[b][3], dt.Rows[b][4]);
                }
            }
            dtProdukSimpan.DataSource = filter;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            cbox_filter.Enabled = false;
            cbox_filter.Enabled = true;
        }

        private void btn_addcategory_Click(object sender, EventArgs e)
        {
            if (txtbox_category.Text == "")
            {
                MessageBox.Show("Error please input first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cbox_category.Items.Add(txtbox_category.Text);
                cbox_filter.Items.Add(txtbox_category.Text);
                int firstnum = 0;
                foreach (DataRow dr in category.Rows)
                {
                    if (firstnum <= Convert.ToInt32(dr[0].ToString().Substring(1)))
                    {
                        firstnum = Convert.ToInt32(dr[0].ToString().Substring(1));
                    }
                }
                string ID = "C" + (firstnum + 1);

                bool check = false;

                foreach (DataRow dr in category.Rows)
                {
                    if (dr[1].ToString() == txtbox_category.Text)
                    {
                        check = true;
                    }
                }
                if (check == false)
                {
                    category.Rows.Add(ID, txtbox_category.Text);
                }
                else
                {
                    MessageBox.Show("Category already input", "Rawr", MessageBoxButtons.OK);
                }
            }
        }

        private void btn_removecategory_Click(object sender, EventArgs e)
        {
            if (dtCategory.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Error please choose a cell", "Rawr",MessageBoxButtons.OK);
            }
            else
            {
                cbox_category.Items.Remove(dtCategory.SelectedCells[0].Value.ToString());
                cbox_filter.Items.Remove(dtCategory.SelectedCells[0].Value.ToString());
                for (int x = dt.Rows.Count - 1; x >= 0; x--)
                {
                    if (dt.Rows[x][4].ToString() == dtCategory.SelectedCells[0].Value.ToString())
                    {
                        dt.Rows.RemoveAt(x);
                    }
                }
                if (dtCategory.SelectedCells[0].Value.ToString().Substring(0) == count.ToString())
                {
                    count--;
                }
                foreach (DataRow b in category.Rows)
                {
                    if (b[1].ToString() == oke)
                    {

                        category.Rows.Remove(b);
                        break;
                    }
                    dtCategory.Rows.RemoveAt(dtCategory.CurrentCell.RowIndex);
                    break;
                }
            }
        }



        private void btn_all_Click(object sender, EventArgs e)
        {
            cbox_filter.Enabled = false;
            dtProdukSimpan.DataSource = dt;
        }

        private void dtProdukSimpan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            hlo = false;
            cbox_filter.Enabled = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (choose == dt.Rows[i][0].ToString())
                {
                    dt.Rows[i][2] = txtbox_nama.Text;
                    dt.Rows[i][3] = txtbox_harga.Text;
                    dt.Rows[i][4] = txtbox_stock.Text;
                    string saved_Data = "";
                    for (int k = 0; k < category.Rows.Count; k++)
                    {
                        if (category.Rows[k][1].ToString() == cbox_filter.SelectedItem.ToString())
                        {
                            saved_Data = category.Rows[k][0].ToString();
                        }
                    }
                    dt.Rows[i][4] = saved_Data;
                }
            }
            filter.Clear();
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                filter.Rows.Add(dt.Rows[j][0].ToString(), dt.Rows[j][1].ToString(), dt.Rows[j][2].ToString(), dt.Rows[j][3].ToString(), dt.Rows[j][4].ToString());
            }
            dtProdukSimpan.DataSource = filter;
        }
      
     

        private void btn_editproduct_Click(object sender, EventArgs e)
        {
            if (dtProdukSimpan.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Error please input first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtbox_stock.Text == "0")
                {
                    dt.Rows.RemoveAt(dtProdukSimpan.SelectedCells[0].RowIndex);
                    dtProdukSimpan.DataSource = dt;
                    txtbox_nama.Clear();
                    txtbox_harga.Clear();
                    txtbox_stock.Clear();
                }
                else
                {
                    dt.Rows[simpan][1] = txtbox_nama.Text;
                    dt.Rows[simpan][3] = txtbox_stock.Text;
                    dt.Rows[simpan][2] = txtbox_harga.Text;
                    for (int i = 0; i < Category.Count; i++)
                    {
                        if (cbox_category.SelectedItem == productname[i])
                        {
                            dt.Rows[simpan][4] = Category[i];
                        }
                    }
                    dtProdukSimpan.DataSource = dt;
                }
            }
        }
  
        private void dtProdukSimpan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            simpan = dtProdukSimpan.SelectedCells[0].RowIndex;
            txtbox_nama.Text = dt.Rows[simpan][1].ToString();
            txtbox_stock.Text = dt.Rows[simpan][3].ToString();
            txtbox_harga.Text = dt.Rows[simpan][2].ToString();
            for (int i = 0; i < productname.Count; i++)
            {
                if (dt.Rows[simpan][4].ToString() == Category[i])
                {
                    cbox_category.Text = Category[i];
                }
            }
            for (int i = 0; i < Category.Count; i++)
            {

                if (dt.Rows[simpan][4].ToString() == Category[i])
                {
                    cbox_category.Text = Category[i];
                }
            }

        }
        public void filterhahaha()
        {
            cbox_filter.Items.Clear();
            foreach (string s in productname)
            {
                cbox_filter.Items.Add(s);
            }
        }
        public void lelah()
        {
            cbox_category.Items.Clear();
            foreach (string s in productname)
            {
                cbox_category.Items.Add(s);
            }
        }

    }
}


