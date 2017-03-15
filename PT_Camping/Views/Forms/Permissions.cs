using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PT_Camping.Model;

namespace PT_Camping.Views.Forms
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
        private readonly DataBase _db;
        private readonly Employe _concernedEmployee;
        private readonly List<Droit> _permissionsList;

        public Permissions(Employe concernedEmployee, DataBase db)
        {
            InitializeComponent();
            _concernedEmployee = concernedEmployee;
            _permissionsList = _concernedEmployee.Personne.Droit.ToList();
            _db = db;

            UpdateCheckBoxes();
        }


        private void UpdateCheckBoxes()
        {
            readClients.Checked = _permissionsList.Any(d => d.Libelle_Droit == "readClients");
            readIssues.Checked = _permissionsList.Any(d => d.Libelle_Droit == "readIssues");
            readEmployees.Checked = _permissionsList.Any(d => d.Libelle_Droit == "readEmployees");
            readProviders.Checked = _permissionsList.Any(d => d.Libelle_Droit == "readProviders");
            readStocks.Checked = _permissionsList.Any(d => d.Libelle_Droit == "readStocks");
            readMap.Checked = _permissionsList.Any(d => d.Libelle_Droit == "readMap");

            writeClients.Checked = _permissionsList.Any(d => d.Libelle_Droit == "writeClients");
            writeIssues.Checked = _permissionsList.Any(d => d.Libelle_Droit == "writeIssues");
            writeEmployees.Checked = _permissionsList.Any(d => d.Libelle_Droit == "writeEmployees");
            writeProviders.Checked = _permissionsList.Any(d => d.Libelle_Droit == "writeProviders");
            writeStocks.Checked = _permissionsList.Any(d => d.Libelle_Droit == "writeStocks");
            writeMap.Checked = _permissionsList.Any(d => d.Libelle_Droit == "writeMap");
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void OkButton_Click(object sender, EventArgs e)
        {
            #region CLIENTS READ PERMISSION

            if (readClients.Checked)
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "readClients") == null)
                {
                    Droit droit = _db.Droit.FirstOrDefault(d => d.Libelle_Droit == "readClients");
                    _concernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "readClients") != null)
                {
                    _concernedEmployee.Personne.Droit.Remove( 
                        _concernedEmployee.Personne.Droit.FirstOrDefault(d => d.Libelle_Droit == "readClients"));
                }
            }
            #endregion

            #region ISSUES READ PERMISSION

            if (readIssues.Checked)
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "readIssues") == null)
                {
                    Droit droit = _db.Droit.FirstOrDefault(d => d.Libelle_Droit == "readIssues");
                    _concernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "readIssues") != null)
                {
                    _concernedEmployee.Personne.Droit.Remove(
                        _concernedEmployee.Personne.Droit.FirstOrDefault(d => d.Libelle_Droit == "readIssues")
                        );
                }
            }
            #endregion

            #region EMPLOYEES READ PERMISSION

            if (readEmployees.Checked)
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "readEmployees") == null)
                {
                    Droit droit = _db.Droit.FirstOrDefault(d => d.Libelle_Droit == "readEmployees");
                    _concernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "readEmployees") != null)
                {
                    _concernedEmployee.Personne.Droit.Remove(
                        _concernedEmployee.Personne.Droit.FirstOrDefault(d => d.Libelle_Droit == "readEmployees")
                        );
                }
            }
            #endregion

            #region PROVIDERS READ PERMISSION

            if (readProviders.Checked)
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "readProviders") == null)
                {
                    Droit droit = _db.Droit.FirstOrDefault(d => d.Libelle_Droit == "readProviders");
                    _concernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "readProviders") != null)
                {
                    _concernedEmployee.Personne.Droit.Remove(
                        _concernedEmployee.Personne.Droit.FirstOrDefault(d => d.Libelle_Droit == "readProviders")
                        );
                }
            }
            #endregion

            #region STOCKS READ PERMISSION

            if (readStocks.Checked)
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "readStocks") == null)
                {
                    Droit droit = _db.Droit.FirstOrDefault(d => d.Libelle_Droit == "readStocks");
                    _concernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "readStocks") != null)
                {
                    _concernedEmployee.Personne.Droit.Remove(
                        _concernedEmployee.Personne.Droit.FirstOrDefault(d => d.Libelle_Droit == "readStocks")
                        );
                }
            }
            #endregion

            #region MAP READ PERMISSION

            if (readMap.Checked)
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "readMap") == null)
                {
                    Droit droit = _db.Droit.FirstOrDefault(d => d.Libelle_Droit == "readMap");
                    _concernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "readMap") != null)
                {
                    _concernedEmployee.Personne.Droit.Remove(
                        _concernedEmployee.Personne.Droit.FirstOrDefault(d => d.Libelle_Droit == "readMap")
                        );
                }
            }

            #endregion
            
            #region CLIENTS WRITE PERMISSION

            if (writeClients.Checked)
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "writeClients") == null)
                {
                    Droit droit = _db.Droit.FirstOrDefault(d => d.Libelle_Droit == "writeClients");
                    _concernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "writeClients") != null)
                {
                    _concernedEmployee.Personne.Droit.Remove(
                        _concernedEmployee.Personne.Droit.FirstOrDefault(d => d.Libelle_Droit == "writeClients")
                        );
                }
            }
            #endregion

            #region ISSUES WRITE PERMISSION

            if (writeIssues.Checked)
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "writeIssues") == null)
                {
                    Droit droit = _db.Droit.FirstOrDefault(d => d.Libelle_Droit == "writeIssues");
                    _concernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "writeIssues") != null)
                {
                    _concernedEmployee.Personne.Droit.Remove(
                        _concernedEmployee.Personne.Droit.FirstOrDefault(d => d.Libelle_Droit == "writeIssues")
                        );
                }
            }
            #endregion

            #region EMPLOYEES WRITE PERMISSION

            if (writeEmployees.Checked)
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "writeEmployees") == null)
                {
                    Droit droit = _db.Droit.FirstOrDefault(d => d.Libelle_Droit == "writeEmployees");
                    _concernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "writeEmployees") != null)
                {
                    _concernedEmployee.Personne.Droit.Remove(
                        _concernedEmployee.Personne.Droit.FirstOrDefault(d => d.Libelle_Droit == "writeEmployees")
                        );
                }
            }
            #endregion

            #region PROVIDERS WRITE PERMISSION

            if (writeProviders.Checked)
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "writeProviders") == null)
                {
                    Droit droit = _db.Droit.FirstOrDefault(d => d.Libelle_Droit == "writeProviders");
                    _concernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "writeProviders") != null)
                {
                    _concernedEmployee.Personne.Droit.Remove(
                        _concernedEmployee.Personne.Droit.FirstOrDefault(d => d.Libelle_Droit == "writeProviders")
                        );
                }
            }
            #endregion

            #region STOCKS WRITE PERMISSION

            if (writeStocks.Checked)
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "writeStocks") == null)
                {
                    Droit droit = _db.Droit.FirstOrDefault(d => d.Libelle_Droit == "writeStocks");
                    _concernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "writeStocks") != null)
                {
                    _concernedEmployee.Personne.Droit.Remove(
                        _concernedEmployee.Personne.Droit.FirstOrDefault(d => d.Libelle_Droit == "writeStocks")
                        );
                }
            }
            #endregion

            #region MAP WRITE PERMISSION

            if (writeMap.Checked)
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "writeMap") == null)
                {
                    Droit droit = _db.Droit.FirstOrDefault(d => d.Libelle_Droit == "writeMap");
                    _concernedEmployee.Personne.Droit.Add(droit);
                }
            }
            else
            {
                if (_permissionsList.Find(d => d.Libelle_Droit == "writeMap") != null)
                {
                    _concernedEmployee.Personne.Droit.Remove(
                        _concernedEmployee.Personne.Droit.FirstOrDefault(d => d.Libelle_Droit == "writeMap")
                        );
                }
            }
            #endregion

            Close();
        }

        private void ReadClients_CheckedChanged(object sender, EventArgs e)
        {
            if (!readClients.Checked)
                writeClients.Checked = false;
        }

        private void ReadIssues_CheckedChanged(object sender, EventArgs e)
        {
            if (!readIssues.Checked)
                writeIssues.Checked = false;
        }

        private void ReadEmployees_CheckedChanged(object sender, EventArgs e)
        {
            if (!readEmployees.Checked)
                writeEmployees.Checked = false;
        }

        private void ReadProviders_CheckedChanged(object sender, EventArgs e)
        {
            if (!readProviders.Checked)
                writeProviders.Checked = false;
        }

        private void ReadStocks_CheckedChanged(object sender, EventArgs e)
        {
            if (!readStocks.Checked)
                writeStocks.Checked = false;
        }

        private void ReadMap_CheckedChanged(object sender, EventArgs e)
        {
            if (!readMap.Checked)
                writeMap.Checked = false;
        }

        private void WriteClients_CheckedChanged(object sender, EventArgs e)
        {
            if (writeClients.Checked)
                readClients.Checked = true;
        }

        private void WriteIssues_CheckedChanged(object sender, EventArgs e)
        {
            if (writeIssues.Checked)
                readIssues.Checked = true;
        }

        private void WriteEmployees_CheckedChanged(object sender, EventArgs e)
        {
            if (writeEmployees.Checked)
                readEmployees.Checked = true;
        }

        private void WriteProviders_CheckedChanged(object sender, EventArgs e)
        {
            if (writeProviders.Checked)
                readProviders.Checked = true;
        }

        private void WriteStocks_CheckedChanged(object sender, EventArgs e)
        {
            if (writeStocks.Checked)
                readStocks.Checked = true;
        }

        private void WriteMap_CheckedChanged(object sender, EventArgs e)
        {
            if (writeMap.Checked)
                readMap.Checked = true;
        }
    }
}
