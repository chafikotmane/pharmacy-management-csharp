using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System.Data;

namespace proj_pharmacell
{
    internal class methodes
    {ADO d = new ADO();
        public void RemplirComboBox(ComboBox comboBox, string nomColonne, string nomTable)
        {
            try
            {
                d.connecter();
                comboBox.Items.Clear();
                // Commande SQL pour sélectionner les données de la colonne dans la table
                string query = $"SELECT {nomColonne} FROM {nomTable}";

                // Affectation de la commande à l'objet SqlCommand
                 d.cmd = new SqlCommand(query, d.con) ;

                // Exécution de la commande et récupération des résultats dans un lecteur de données
                d.dr = d.cmd.ExecuteReader();

                // Ajout des éléments au ComboBox
                while (d.dr.Read())
                {
                    comboBox.Items.Add(d.dr[nomColonne].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du remplissage du ComboBox : " + ex.Message);
            }
            finally
            {
                // Fermeture du lecteur de données et de la connexion
                d.dr.Close();
                d.deconnecter();
            }
        }
        public void RemplirGrid(string table,DataGridView dgv)
        {
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.connecter();
            d.cmd.CommandText = $"select * from {table} ";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dgv.DataSource = d.dt;
            d.dr.Close();
        }
        //public void ExportToExcel(DataGridView dataGridView, string filePath)
        //{
        //    // Créer un nouveau fichier Excel
        //    using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
        //    {
        //        // Ajouter une nouvelle feuille de calcul
        //        WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
        //        workbookPart.Workbook = new Workbook();

        //        WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
        //        worksheetPart.Worksheet = new Worksheet(new SheetData());

        //        Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
        //        Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Sheet1" };
        //        sheets.Append(sheet);

        //        // Remplir les données dans la feuille de calcul
        //        SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
        //        DataTable dt = (DataTable)dataGridView.DataSource;

        //        Row headerRow = new Row();
        //        foreach (DataColumn column in dt.Columns)
        //        {
        //            Cell cell = new Cell();
        //            cell.DataType = CellValues.String;
        //            cell.CellValue = new CellValue(column.ColumnName);
        //            headerRow.AppendChild(cell);
        //        }
        //        sheetData.AppendChild(headerRow);

        //        foreach (DataRow row in dt.Rows)
        //        {
        //            Row newRow = new Row();
        //            foreach (var cellValue in row.ItemArray)
        //            {
        //                Cell cell = new Cell();
        //                cell.DataType = CellValues.String;
        //                cell.CellValue = new CellValue(cellValue.ToString());
        //                newRow.AppendChild(cell);
        //            }
        //            sheetData.AppendChild(newRow);
        //        }

        //        // Enregistrer le fichier Excel
        //        workbookPart.Workbook.Save();
        //    }

        //    MessageBox.Show("Les données ont été exportées avec succès vers Excel.", "Export Excel",
        //                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        public void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            try
            {
                using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
                {
                    WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
                    workbookPart.Workbook = new Workbook();

                    WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                    worksheetPart.Worksheet = new Worksheet(new SheetData());

                    Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
                    Sheet sheet = new Sheet()
                    {
                        Id = workbookPart.GetIdOfPart(worksheetPart),
                        SheetId = 1,
                        Name = "Feuille1"
                    };
                    sheets.Append(sheet);

                    SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                    // 🔹 En-têtes des colonnes
                    Row headerRow = new Row();
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        if (column.Visible)
                        {
                            Cell cell = new Cell
                            {
                                DataType = CellValues.String,
                                CellValue = new CellValue(column.HeaderText)
                            };
                            headerRow.AppendChild(cell);
                        }
                    }
                    sheetData.AppendChild(headerRow);

                    // 🔹 Lignes de données
                    foreach (DataGridViewRow dgvRow in dataGridView.Rows)
                    {
                        if (!dgvRow.IsNewRow)
                        {
                            Row newRow = new Row();
                            foreach (DataGridViewCell cell in dgvRow.Cells)
                            {
                                if (cell.Visible)
                                {
                                    string value = cell.Value?.ToString() ?? "";
                                    Cell excelCell = new Cell
                                    {
                                        DataType = CellValues.String,
                                        CellValue = new CellValue(value)
                                    };
                                    newRow.AppendChild(excelCell);
                                }
                            }
                            sheetData.AppendChild(newRow);
                        }
                    }

                    workbookPart.Workbook.Save();
                }

                MessageBox.Show("Les données ont été exportées avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'export : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

}

