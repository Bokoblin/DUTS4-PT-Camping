using PT_Camping.Model;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PT_Camping
{
    /// <summary>
    /// This dialog allows to select the permission given to each employee
    /// It is divided in two category READ and WRITE :
    /// - Without READ or WRITE, you can't access management process of the app
    /// - With only READ, you can only read the informations of the authorized section
    /// - With READ and WRITE, you can read the informations of the authorized section and edit them
    /// 
    /// Note : WRITE permission can't be set without READ permission
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 22/02/17
    public partial class Permissions : Form
    {
        private DataBase db;
        private Employe mConcernedEmployee;
        private List<Droit> permissionsList;

        public Permissions(Employe concernedEmployee, DataBase db)
        {
            InitializeComponent();
            mConcernedEmployee = concernedEmployee;
            permissionsList = mConcernedEmployee.Personne.Droit.ToList();
            this.db = db;

            updateCheckBoxes();
        }


        private void updateCheckBoxes()
        {
            readClients.Checked = permissionsList.Any(d => d.Libelle_Droit == "readClients");
            readIssues.Checked = permissionsList.Any(d => d.Libelle_Droit == "readIssues");
            readEmployees.Checked = permissionsList.Any(d => d.Libelle_Droit == "readEmployees");
            readProviders.Checked = permissionsList.Any(d => d.Libelle_Droit == "readProviders");
            readStocks.Checked = permissionsList.Any(d => d.Libelle_Droit == "readStocks");
            readMap.Checked = permissionsList.Any(d => d.Libelle_Droit == "readMap");

            writeClients.Checked = permissionsList.Any(d => d.Libelle_Droit == "writeClients");
            writeIssues.Checked = permissionsList.Any(d => d.Libelle_Droit == "writeIssues");
            writeEmployees.Checked = permissionsList.Any(d => d.Libelle_Droit == "writeEmployees");
            writeProviders.Checked = permissionsList.Any(d => d.Libelle_Droit == "writeProviders");
            writeStocks.Checked = permissionsList.Any(d => d.Libelle_Droit == "writeStocks");
            writeMap.Checked = permissionsList.Any(d => d.Libelle_Droit == "writeMap");
        }


        private void onCancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }


        private void onOkButtonClick(object sender, EventArgs e)
        {
            #region CLIENTS READ PERMISSION

            if (readClients.Checked)
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "readClients") == null)
                {
                    Droit droit = db.Droit.Where(d => d.Libelle_Droit == "readClients").FirstOrDefault();
                    mConcernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "readClients") != null)
                {
                    mConcernedEmployee.Personne.Droit.Remove(
                        mConcernedEmployee.Personne.Droit.Where(d => d.Libelle_Droit == "readClients").FirstOrDefault()
                        );
                }
            }
            #endregion

            #region ISSUES READ PERMISSION

            if (readIssues.Checked)
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "readIssues") == null)
                {
                    Droit droit = db.Droit.Where(d => d.Libelle_Droit == "readIssues").FirstOrDefault();
                    mConcernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "readIssues") != null)
                {
                    mConcernedEmployee.Personne.Droit.Remove(
                        mConcernedEmployee.Personne.Droit.Where(d => d.Libelle_Droit == "readIssues").FirstOrDefault()
                        );
                }
            }
            #endregion

            #region EMPLOYEES READ PERMISSION

            if (readEmployees.Checked)
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "readEmployees") == null)
                {
                    Droit droit = db.Droit.Where(d => d.Libelle_Droit == "readEmployees").FirstOrDefault();
                    mConcernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "readEmployees") != null)
                {
                    mConcernedEmployee.Personne.Droit.Remove(
                        mConcernedEmployee.Personne.Droit.Where(d => d.Libelle_Droit == "readEmployees").FirstOrDefault()
                        );
                }
            }
            #endregion

            #region PROVIDERS READ PERMISSION

            if (readProviders.Checked)
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "readProviders") == null)
                {
                    Droit droit = db.Droit.Where(d => d.Libelle_Droit == "readProviders").FirstOrDefault();
                    mConcernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "readProviders") != null)
                {
                    mConcernedEmployee.Personne.Droit.Remove(
                        mConcernedEmployee.Personne.Droit.Where(d => d.Libelle_Droit == "readProviders").FirstOrDefault()
                        );
                }
            }
            #endregion

            #region STOCKS READ PERMISSION

            if (readStocks.Checked)
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "readStocks") == null)
                {
                    Droit droit = db.Droit.Where(d => d.Libelle_Droit == "readStocks").FirstOrDefault();
                    mConcernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "readStocks") != null)
                {
                    mConcernedEmployee.Personne.Droit.Remove(
                        mConcernedEmployee.Personne.Droit.Where(d => d.Libelle_Droit == "readStocks").FirstOrDefault()
                        );
                }
            }
            #endregion

            #region MAP READ PERMISSION

            if (readMap.Checked)
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "readMap") == null)
                {
                    Droit droit = db.Droit.Where(d => d.Libelle_Droit == "readMap").FirstOrDefault();
                    mConcernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "readMap") != null)
                {
                    mConcernedEmployee.Personne.Droit.Remove(
                        mConcernedEmployee.Personne.Droit.Where(d => d.Libelle_Droit == "readMap").FirstOrDefault()
                        );
                }
            }

            #endregion
            
            #region CLIENTS WRITE PERMISSION

            if (writeClients.Checked)
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "writeClients") == null)
                {
                    Droit droit = db.Droit.Where(d => d.Libelle_Droit == "writeClients").FirstOrDefault();
                    mConcernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "writeClients") != null)
                {
                    mConcernedEmployee.Personne.Droit.Remove(
                        mConcernedEmployee.Personne.Droit.Where(d => d.Libelle_Droit == "writeClients").FirstOrDefault()
                        );
                }
            }
            #endregion

            #region ISSUES WRITE PERMISSION

            if (writeIssues.Checked)
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "writeIssues") == null)
                {
                    Droit droit = db.Droit.Where(d => d.Libelle_Droit == "writeIssues").FirstOrDefault();
                    mConcernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "writeIssues") != null)
                {
                    mConcernedEmployee.Personne.Droit.Remove(
                        mConcernedEmployee.Personne.Droit.Where(d => d.Libelle_Droit == "writeIssues").FirstOrDefault()
                        );
                }
            }
            #endregion

            #region EMPLOYEES WRITE PERMISSION

            if (writeEmployees.Checked)
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "writeEmployees") == null)
                {
                    Droit droit = db.Droit.Where(d => d.Libelle_Droit == "writeEmployees").FirstOrDefault();
                    mConcernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "writeEmployees") != null)
                {
                    mConcernedEmployee.Personne.Droit.Remove(
                        mConcernedEmployee.Personne.Droit.Where(d => d.Libelle_Droit == "writeEmployees").FirstOrDefault()
                        );
                }
            }
            #endregion

            #region PROVIDERS WRITE PERMISSION

            if (writeProviders.Checked)
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "writeProviders") == null)
                {
                    Droit droit = db.Droit.Where(d => d.Libelle_Droit == "writeProviders").FirstOrDefault();
                    mConcernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "writeProviders") != null)
                {
                    mConcernedEmployee.Personne.Droit.Remove(
                        mConcernedEmployee.Personne.Droit.Where(d => d.Libelle_Droit == "writeProviders").FirstOrDefault()
                        );
                }
            }
            #endregion

            #region STOCKS WRITE PERMISSION

            if (writeStocks.Checked)
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "writeStocks") == null)
                {
                    Droit droit = db.Droit.Where(d => d.Libelle_Droit == "writeStocks").FirstOrDefault();
                    mConcernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "writeStocks") != null)
                {
                    mConcernedEmployee.Personne.Droit.Remove(
                        mConcernedEmployee.Personne.Droit.Where(d => d.Libelle_Droit == "writeStocks").FirstOrDefault()
                        );
                }
            }
            #endregion

            #region MAP WRITE PERMISSION

            if (writeMap.Checked)
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "writeMap") == null)
                {
                    Droit droit = db.Droit.Where(d => d.Libelle_Droit == "writeMap").FirstOrDefault();
                    mConcernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (permissionsList.Find(d => d.Libelle_Droit == "writeMap") != null)
                {
                    mConcernedEmployee.Personne.Droit.Remove(
                        mConcernedEmployee.Personne.Droit.Where(d => d.Libelle_Droit == "writeMap").FirstOrDefault()
                        );
                }
            }
            #endregion

            this.Close();
        }

        private void readClients_CheckedChanged(object sender, EventArgs e)
        {
            if (!readClients.Checked)
                writeClients.Checked = false;
        }

        private void readIssues_CheckedChanged(object sender, EventArgs e)
        {
            if (!readIssues.Checked)
                writeIssues.Checked = false;
        }

        private void readEmployees_CheckedChanged(object sender, EventArgs e)
        {
            if (!readEmployees.Checked)
                writeEmployees.Checked = false;
        }

        private void readProviders_CheckedChanged(object sender, EventArgs e)
        {
            if (!readProviders.Checked)
                writeProviders.Checked = false;
        }

        private void readStocks_CheckedChanged(object sender, EventArgs e)
        {
            if (!readStocks.Checked)
                writeStocks.Checked = false;
        }

        private void readMap_CheckedChanged(object sender, EventArgs e)
        {
            if (!readMap.Checked)
                writeMap.Checked = false;
        }

        private void writeClients_CheckedChanged(object sender, EventArgs e)
        {
            if (writeClients.Checked)
                readClients.Checked = true;
        }

        private void writeIssues_CheckedChanged(object sender, EventArgs e)
        {
            if (writeIssues.Checked)
                readIssues.Checked = true;
        }

        private void writeEmployees_CheckedChanged(object sender, EventArgs e)
        {
            if (writeEmployees.Checked)
                readEmployees.Checked = true;
        }

        private void writeProviders_CheckedChanged(object sender, EventArgs e)
        {
            if (writeProviders.Checked)
                readProviders.Checked = true;
        }

        private void writeStocks_CheckedChanged(object sender, EventArgs e)
        {
            if (writeStocks.Checked)
                readStocks.Checked = true;
        }

        private void writeMap_CheckedChanged(object sender, EventArgs e)
        {
            if (writeMap.Checked)
                readMap.Checked = true;
        }
    }
}
