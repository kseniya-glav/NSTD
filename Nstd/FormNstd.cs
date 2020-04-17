using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Nstd
{
    public partial class FormNstd : Form
    {
        #region листы+подключалка
        List<Fields> alFields = new List<Fields>();
        List<Fields> unselfield = new List<Fields>();
        List<Fields> selfield = new List<Fields>();
        List<Fields> unselfielord = new List<Fields>();
        List<Fields> selfielord = new List<Fields>();
        List<Condition> vira = new List<Condition>();

        private readonly string _sConnStr = new NpgsqlConnectionStringBuilder
        {

            Host = "localhost",
            Port = 5432,
            Database = "carrental2",
            Username = "postgres",
            Password = "12345",
            MaxAutoPrepare = 10,
            AutoPrepareMinUsages = 2
        }.ConnectionString;
        #endregion



        public FormNstd()
        {
            InitializeComponent();
            LoadalFields();
            LoadUnselfield();
            InitializaeNullCbConnective();
            InitializeLbUnselfield();
            InitializeCbConditionNameField();
            
        }

        void InitializaeNullCbConnective()
        {
            cbsviaz.Items.Clear();
            cbsviaz.Items.Add("-");
            cbsviaz.SelectedIndex = 0;
        }

        void InitializeAndOrCbConnective()
        {
            cbsviaz.Items.Clear();
            cbsviaz.Items.AddRange(new[] { "И", "ИЛИ" }); ;
            cbsviaz.SelectedIndex = 0;
        }

        void LoadalFields()
        {
            try
            {
                using (var sConn = new NpgsqlConnection(_sConnStr))
                {
                    sConn.Open();
                    var sCommand = new NpgsqlCommand
                    {
                        Connection = sConn,
                        CommandText = @"SELECT field_name, table_name, field_type, transl_fn, category_name FROM _fields ORDER BY category_name"
                    };
                    var reader = sCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        alFields.Add(new Fields(reader["field_name"].ToString(), reader["table_name"].ToString(),
                            reader["field_type"].ToString(), reader["transl_fn"].ToString(), reader["category_name"].ToString()));
                    }
                }
            }
            catch
            {
                MessageBox.Show("");//cltkfnm
            }
            
        }

        void LoadUnselfield()
        {
            foreach(var fiel in alFields)
            {
                unselfield.Add(fiel);
            }
        }

        void InitializeCbConditionNameField()
        {
            cbnamefil.DataSource = alFields;
            cbnamefil.ValueMember = "Self";
            cbnamefil.DisplayMember = "Transl_fn";
            cbnamefil.SelectedIndex = -1;
        }

        void InitializeLbUnselfield()
        {
            notselfil.Items.Clear();
            foreach (var fiel in unselfield)
            {
                    notselfil.Items.Add(fiel.translit);
            }
        }

        void InitializeLbselfield()
        {
            sel_fil.Items.Clear();
            foreach (var fiel in selfield)
            {
                sel_fil.Items.Add(fiel.translit);
            }
        }

        void InitializeLbunselfielord()
        {
            notselord.Items.Clear();
            foreach (var fiel in unselfielord)
            {
                notselord.Items.Add(fiel.translit);
            }
        }
        void InitializeLbselfielord()
        {
            lvord_sel.Items.Clear();
            foreach (var fiel in selfielord)
            {
                lvord_sel.Items.Add(fiel.translit);
            }
        }

        // Общая инициализация интерфейса
        public void InitializeInterface()
        {

            InitializeLbUnselfield();
            InitializeLbselfield();
            InitializeLbunselfielord();
            InitializeLbselfielord();
        }
        // Инициализируем "поля: все поля" и "условия: имя поля"
        public void initialize_lbAllFields_cbNameField()
        {
            notselfil.Items.Clear();
            cbnamefil.Items.Clear();
        }

        // Кнопка >
        private void btFieldRight_Click(object sender, EventArgs e)
        {
            int i = notselfil.SelectedIndex;
            if (i != -1)
            {
                selfield.Add(unselfield[i]);
                unselfielord.Add(unselfield[i]);
                unselfield.RemoveAt(i);
            }
            InitializeInterface();
        }
        // Кнопка <
        private void btFieldLeft_Click(object sender, EventArgs e)
        {
            int i = sel_fil.SelectedIndex;
            if (i != -1)
            {
                unselfield.Add(selfield[i]);
                var dsd = selfield[i];
                selfield.RemoveAt(i);
              
            }
            InitializeInterface();
        }
        private void remuvebackbuton(Fields ssss)
        {
            
            foreach(var dddd in unselfielord)
            {
                if (dddd.field_name == ssss.field_name)
                {
                    foreach (var ffff in selfielord)
                    {
                        if(ffff.field_name == ssss.field_name)
                            selfielord.Remove(ffff);
                    }
                    unselfielord.Remove(dddd);
                }
                    
            }
        }
        // Кнопка >>
        private void btAllFieldRight_Click(object sender, EventArgs e)
        {
            selfield.AddRange(unselfield);
            unselfielord.AddRange(unselfield);
            unselfield.Clear();

            InitializeInterface();
        }
        // Кнопка <<
        private void btAllFieldLeft_Click(object sender, EventArgs e)
        {
            unselfield.AddRange(selfield);
            selfield.Clear();
            unselfielord.Clear();
            selfielord.Clear();
            InitializeInterface();
        }

        private void cbNameField_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbviroj.Items.Clear();
            int i = cbnamefil.SelectedIndex;

            if (i >= 0)
            {
                cbkategori.Items.Clear();
                cbviroj.Items.Clear();
                cbviroj.Text = "";
                cbviroj.DropDownStyle = ComboBoxStyle.DropDown;

                var selected_field = (Fields)cbnamefil.SelectedItem;
                var fieltype = (selected_field).type_f.ToLower();

                using (var sConn = new NpgsqlConnection(_sConnStr))
                {
                    sConn.Open();
                    var sCommand = new NpgsqlCommand
                    {
                        Connection = sConn,
                        CommandText = @"SELECT DISTINCT " + selected_field.field_name + " FROM " +
                        selected_field.table_name + " " +
                        "ORDER BY " + selected_field.field_name + ";"
                    };

                    var reader = sCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                            cbviroj.Items.Add(reader[0]);

                    }
                }
                if (fieltype == "boolean")
                {
                    cbviroj.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbviroj.Visible = true;
                    dtdat.Visible = false;
                    cbkategori.Items.AddRange(new[] { "=", "<>" });
                    cbviroj.Items.Clear();
                    cbviroj.Items.AddRange(new[] { "TRUE", "FALSE" });
                    return;
                }

                if (fieltype == "integer" || fieltype == "int" || fieltype == "bigint" || fieltype == "smallint" || fieltype == "real" || fieltype == "double precision" || fieltype == "numeric" || fieltype == "decimal")
                {
                    cbviroj.Visible = true;
                    dtdat.Visible = false;
                    cbkategori.Items.AddRange(new[] { "=", "<>", ">", "<", ">=", "<=", });
                    return;
                }
                if (fieltype == "string" || fieltype == "text" || fieltype == "varchar" || fieltype == "character varying" || fieltype == "char" || fieltype == "character")
                {
                    cbviroj.Visible = true;
                    dtdat.Visible = false;
                    cbkategori.Items.AddRange(new[] { "=", "<>", "LIKE" });
                    return;
                }
                if (fieltype == "date")
                {
                    cbviroj.Visible = false;
                    dtdat.Visible = true;
                    dtdat.Format = DateTimePickerFormat.Short;
                    cbkategori.Items.AddRange(new[] { "=", "<>", ">", "<", ">=", "<=", });
                    return;
                }
                if (fieltype == "timestamp")
                {
                    cbviroj.Visible = false;
                    dtdat.Visible = true;
                    dtdat.Format = DateTimePickerFormat.Long;
                    cbkategori.Items.AddRange(new[] { "=", "<>", ">", "<", ">=", "<=", });
                    return;
                }
                if (fieltype == "time")
                {
                    cbviroj.Visible = false;
                    dtdat.Visible = true;
                    dtdat.Format = DateTimePickerFormat.Time;
                    cbkategori.Items.AddRange(new[] { "=", "<>", ">", "<", ">=", "<=", });
                    return;
                }

            }
        }
        // Кнопка добавить условие
        private void btAdd_Click(object sender, EventArgs e)//нормас
        {

            if (cbnamefil.SelectedItem == null)
                MessageBox.Show("поле не выбрано!");
            else
            if (cbkategori.Text == "")
                MessageBox.Show("критерий не выбран!");
            else
            if (cbsviaz.Text == "")
                MessageBox.Show("тип связи не выбран!");
            else
            {
                string typecf = ((Fields)cbnamefil.SelectedItem).type_f.ToLower();
                if (typecf == "boolean")
                {
                    if (cbviroj.Text == "") {
                        MessageBox.Show("выражение пустое !");
                        return;
                    }
                }
                if (typecf == "integer" || typecf == "int" || typecf == "bigint" || typecf == "smallint")
                {
                    if (cbviroj.Text == "") {
                        MessageBox.Show("выражение пустое !");
                        return;
                    }
                    try
                    {
                        Convert.ToInt64(cbviroj.Text);
                    }
                    catch
                    {
                        MessageBox.Show("В выражении значение не является числом!");
                        return;
                    }
                }
                if (typecf == "real" || typecf == "double precision" || typecf == "numeric" || typecf == "decimal")
                {
                    if (cbviroj.Text == "")
                    {
                        MessageBox.Show("выражение пустое !");
                        return;
                    }
                    try
                    {
                        Convert.ToDouble(cbviroj.Text);
                    }
                    catch
                    {
                        MessageBox.Show("В выражении значение не является числом или число слишком большое!");
                        return;
                    }
                }

                if (typecf == "text" || typecf == "varchar" || typecf == "character varying" || typecf == "char" || typecf == "character")
                {
                    if (cbviroj.Text == "") {
                        MessageBox.Show("выражение пустое !");
                        return;
                    }
                    cbviroj.Visible = true;
                    dtdat.Visible = false;
                }

                if (typecf == "date")
                {
                    cbviroj.Visible = false;
                    dtdat.Visible = true;
                    dtdat.Format = DateTimePickerFormat.Short;
                }
                if (typecf == "timestamp")
                {
                    cbviroj.Visible = false;
                    dtdat.Visible = true;
                    dtdat.Format = DateTimePickerFormat.Long;
                }
                if (typecf == "time")
                {
                    cbviroj.Visible = false;
                    dtdat.Visible = true;
                    dtdat.Format = DateTimePickerFormat.Time;
                }
                

                string vir_text;

                //для комбобокса
                if (cbviroj.Visible)
                    if(cbkategori.Text == "LIKE")
                        vir_text = "%"+cbviroj.Text + "%";
                    else vir_text =  cbviroj.Text ;
                else vir_text = dtdat.Text;

                vira.Add(new Condition(((Fields)cbnamefil.SelectedItem), cbkategori.Text, vir_text, cbsviaz.Text));
                lvwhere.Items.Add(new ListViewItem(new[]
                        {
                        ((Fields)cbnamefil.SelectedItem).translit,
                        cbkategori.Text,
                        vir_text,
                       cbsviaz.Text
                }));
            }

            if (vira.Count == 1) InitializeAndOrCbConnective();
        }

        void inicvir()
        {
            lvwhere.Items.Clear();
            foreach (var virka in vira)
            {
                lvwhere.Items.Add(new ListViewItem(new[]
                        {
                        virka.fiel.translit,
                        virka.operat,
                        virka.value,
                       virka.sviazz
                    }));
            }
        }

        // Кнопка удаление условий
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lvwhere.SelectedItems.Count > 0)
            {
                ListViewItem seledItem = lvwhere.SelectedItems[0];

                int i = lvwhere.SelectedIndices[0];

                lvwhere.Items.Remove(seledItem);

                vira.RemoveAt(i);

                if(i == 0 && vira.Count > 0)
                {
                    vira[0].sviazz = "-";
                    inicvir();
                }
                
            }
            else
                MessageBox.Show("Выберите условие!");

            if (vira.Count == 0)
                InitializaeNullCbConnective();
        }
        // d
        private void lbSelectedFields_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
     
        void Addvir(string tablename1, string tablename2, List<string> rela)
        {
            using (var sConn = new NpgsqlConnection(_sConnStr))
            {
                sConn.Open();
                var sCommand = new NpgsqlCommand
                {
                    Connection = sConn,
                    CommandText = @"SELECT relations FROM _reltable
                             WHERE table1 = @name_table1 AND table2 = @name_table2
                                OR table1 = @name_table2 AND table2 = @name_table1;"
                };
                sCommand.Parameters.AddWithValue("@name_table1", tablename1);
                sCommand.Parameters.AddWithValue("@name_table2", tablename2);
                var reader = sCommand.ExecuteReader();
                if (reader.Read())
                {
                    var relka = reader["relations"].ToString();
                    if (!rela.Contains(relka))
                        rela.Add(relka);
                }
            }
        }

        void find(string tablename1, string tablename2, List<string> tranzitnamestables, List<string> rel)
        {
            if(!tranzitnamestables.Contains(tablename1))
                tranzitnamestables.Add(tablename1);
            if (!tranzitnamestables.Contains(tablename2))
                tranzitnamestables.Add(tablename2);

            using (var sConn = new NpgsqlConnection(_sConnStr))
            {
                sConn.Open();
                var sCommand = new NpgsqlCommand
                {
                    Connection = sConn,
                    CommandText = @"SELECT table1, table2, relations, via FROM _reltable
                             WHERE table1 = @name_table1 AND table2 = @name_table2
                                OR table1 = @name_table2 AND table2 = @name_table1;"
                };
                sCommand.Parameters.AddWithValue("@name_table1", tablename1);
                sCommand.Parameters.AddWithValue("@name_table2", tablename2);
                var reader = sCommand.ExecuteReader();
                if (reader.Read())
                { 
                    if (reader.IsDBNull(2))
                    {
                        Addvir(reader["table1"].ToString(), reader["via"].ToString(), rel);
                        find(reader["via"].ToString(), reader["table2"].ToString(), tranzitnamestables, rel);
                    }
                    else
                    {
                        var relation = reader["relations"].ToString();
                        if (!rel.Contains(relation)) rel.Add(relation);
                    }
                }
                else MessageBox.Show("Не хватает связи между " + tablename1 + " и " + tablename2);
            }          
        }

        public string getsqlkod()
        {
            var virajenie = new List<string>();//хранит список, где элемент связь по внешнему ключу

            var namestables = new List<string>();

            var tranzitnamestables = new List<string>();

            //
            foreach (var field in selfield)
            {
                if (!namestables.Contains(field.table_name))
                    namestables.Add(field.table_name);
            }

            //
            foreach (var condition in vira)
            {
                if (!namestables.Contains(condition.fiel.table_name))
                    namestables.Add(condition.fiel.table_name);
            }
            
            for(int i = 0; i < namestables.Count; i++)
                for(int j = i + 1; j < namestables.Count; j++)
                {

                    using (var sConn = new NpgsqlConnection(_sConnStr))
                    {
                        sConn.Open();
                        var sCommand = new NpgsqlCommand
                        {
                            Connection = sConn,
                            CommandText = @"SELECT table1, table2, relations, via FROM _reltable
                             WHERE table1 = @name_table1 AND table2 = @name_table2
                                 OR table1 = @name_table2 AND table2 = @name_table1;"
                        };
                        sCommand.Parameters.AddWithValue("@name_table1", namestables[i]);
                        sCommand.Parameters.AddWithValue("@name_table2", namestables[j]);
                        var reader = sCommand.ExecuteReader();
                        /*есть связь между таблицами*/
                        if (reader.Read())
                        {                          
                             /*связь прямая*/
                            if (!reader.IsDBNull(2))
                            {
                                
                                //добавляем связку
                                string relka = reader["relations"].ToString();
                                if (!virajenie.Contains(relka))
                                    virajenie.Add(relka);
                            }
                            else
                            {
                                //добавляем связь к следующей таблице

                                Addvir(reader["table1"].ToString(), reader["via"].ToString(), virajenie);
                                //ищем путь
                                find(reader["via"].ToString(), reader["table2"].ToString(), tranzitnamestables, virajenie);
                            }
                            
                        }
                    }
                }

            string strokaitoga = "SELECT DISTINCT ";
            //добавляем в запрос имена столбцов для вывода
            foreach (var field in selfield)
                strokaitoga += field.table_name + "." + field.field_name + ", ";

            strokaitoga = strokaitoga.Remove(strokaitoga.Length - 2, 2);

            strokaitoga += " FROM ";

            //добавляем транзитные таблицы к нетранзитным
           foreach(var tranzit_name_table in tranzitnamestables)
            {
                if (!namestables.Contains(tranzit_name_table))
                    namestables.Add(tranzit_name_table);
            }

            //добавляем в запрос используемые таблицы
            foreach (var name_table in namestables)
                strokaitoga += name_table + ", ";

            strokaitoga = strokaitoga.Remove(strokaitoga.Length - 2, 2);
            
            if(vira.Count > 0 || virajenie.Count > 0)
                strokaitoga += " WHERE ";

            if (vira.Count > 0)
            {
                int indexvir = 0;
                //добавляем условия для столбцов
                strokaitoga += "( ";
                foreach (var cond in vira)
                {
                    string typefield = cond.fiel.type_f.ToLower();
                    if (cond.sviazz == "И")
                        strokaitoga += " AND ";
                    else
                        if (cond.sviazz == "ИЛИ")
                        strokaitoga += " OR ";
                    strokaitoga += cond.fiel.table_name + "." + cond.fiel.field_name + " " + cond.operat + " ";

                    if (typefield == "text" || typefield == "varchar" || typefield == "character varying" 
                        || typefield == "char" || typefield == "character")
                    {
                        strokaitoga += "@" + indexvir.ToString();                       
                    }
                    else
                    {
                        if(typefield == "date" || typefield == "time" || typefield == "timestamp")
                            strokaitoga += " '" + cond.value + "' ";
                        else
                            strokaitoga += cond.value;                    
                    }

                    indexvir++;
                }
                strokaitoga += " )";
            }

            if (virajenie.Count > 0)
            {
                if (vira.Count > 0)
                    strokaitoga += " AND ";

                strokaitoga += " ( ";

                //добавляем связи таблиц
                foreach (var relation in virajenie)
                    strokaitoga += relation + " AND ";

                strokaitoga = strokaitoga.Remove(strokaitoga.Length - 4, 4);
                strokaitoga += ")";
            }

           

            if (selfielord.Count > 0)
            {
                bool ffedff = true ;
                //strokaitoga += " ORDER BY ";

                foreach (var selectedField in selfielord)
                {
                    if (selectedField.orderField != Order.no)
                    {
                        if(ffedff) strokaitoga += " ORDER BY ";
                        ffedff = false;
                        strokaitoga += selectedField.table_name + "." + selectedField.field_name;
                        if (selectedField.orderField == Order.desc)
                            strokaitoga += " DESC ";
                        else
                            strokaitoga += " ASC ";
                        strokaitoga += ", ";
                    }
                }

                if (!ffedff) strokaitoga = strokaitoga.Remove(strokaitoga.Length - 2);//проверить 
            }

            
            strokaitoga += " ;";


            return strokaitoga;           
        }

        public string getsqlkodToShow()
        {
            var viraje = new List<string>();//хранит список, где элемент связь по внешнему ключу

            var namestables = new List<string>();

            var tranzitnamestables = new List<string>();

            foreach (var fieldd in selfield)
            {
                if (!namestables.Contains(fieldd.table_name))
                    namestables.Add(fieldd.table_name);
            }

            //добавляем список имен таблиц, столбцы которых указаны в условиях
            foreach (var condition in vira)
            {
                if (!namestables.Contains(condition.fiel.table_name))
                    namestables.Add(condition.fiel.table_name);
            }

            for (int i = 0; i < namestables.Count; i++)
                for (int j = i + 1; j < namestables.Count; j++)
                {

                    using (var sConn = new NpgsqlConnection(_sConnStr))
                    {
                        sConn.Open();
                        var sCommand = new NpgsqlCommand
                        {
                            Connection = sConn,
                            CommandText = @"SELECT table1, table2, relations, via FROM _reltable
                             WHERE table1 = @name_table1 AND table2 = @name_table2
                                 OR table1 = @name_table2 AND table2 = @name_table1;"
                        };
                        sCommand.Parameters.AddWithValue("@name_table1", namestables[i]);
                        sCommand.Parameters.AddWithValue("@name_table2", namestables[j]);
                        var reader = sCommand.ExecuteReader();
                        /*есть связь между таблицами*/
                        if (reader.Read())
                        {
                            /*связь прямая*/
                            if (!reader.IsDBNull(2))
                            {
                                string relatio = reader["relations"].ToString();
                                if (!viraje.Contains(relatio))
                                    viraje.Add(relatio);
                            }
                            else
                            {
                                Addvir(reader["table1"].ToString(), reader["via"].ToString(), viraje);
                                find(reader["via"].ToString(), reader["table2"].ToString(), tranzitnamestables, viraje);
                            }
                        }
                    }
                }

            string strokaitoga = "SELECT DISTINCT ";
            foreach (var field in selfield)
                strokaitoga += field.table_name + "." + field.field_name + ", ";

            strokaitoga = strokaitoga.Remove(strokaitoga.Length - 2, 2);

            strokaitoga += " FROM ";

            foreach (var tranzinameable in tranzitnamestables)
            {
                if (!namestables.Contains(tranzinameable))
                    namestables.Add(tranzinameable);
            }

            foreach (var namtable in namestables)
                strokaitoga += namtable + ", ";

            strokaitoga = strokaitoga.Remove(strokaitoga.Length - 2, 2);

            if (vira.Count > 0 || viraje.Count > 0) strokaitoga += " WHERE ";

            if (vira.Count > 0)
            {
                int index_condition = 0;
                //добавляем условия для столбцов
                strokaitoga += "( ";
                foreach (var viroj in vira)
                {
                    string type_field = viroj.fiel.type_f.ToLower();
                    if (viroj.sviazz == "И")
                        strokaitoga += " AND ";
                    else
                        if (viroj.sviazz == "ИЛИ")
                        strokaitoga += " OR ";
                    strokaitoga += viroj.fiel.table_name + "." + viroj.fiel.field_name + " " + viroj.operat + " ";

                    if (type_field == "text" || type_field == "varchar" || type_field == "character varying"
                        || type_field == "char" || type_field == "character")
                        strokaitoga += " '" + viroj.value + "' ";
                    else
                    {
                        if (type_field == "date" || type_field == "time" || type_field == "timestamp")
                            strokaitoga += " {" + viroj.value + "} ";
                        else
                            strokaitoga += viroj.value;                    
                    }
                    
                    index_condition++;
                }
                strokaitoga += " )";
            }

            if (viraje.Count > 0)
            {
                if (vira.Count > 0)
                    strokaitoga += " AND ";

                strokaitoga += " ( ";

                //добавляем связи таблиц
                foreach (var relation in viraje)
                    strokaitoga += relation + " AND ";

                strokaitoga = strokaitoga.Remove(strokaitoga.Length - 4, 4);
                strokaitoga += ")";
            }

            if (selfielord.Count > 0)
            {
                bool ffedff = true;
                foreach (var selectedField in selfielord)
                {
                    if (selectedField.orderField != Order.no)
                    {
                        if (ffedff) strokaitoga += " ORDER BY ";
                        ffedff = false;
                        strokaitoga += selectedField.table_name + "." + selectedField.field_name;
                        if (selectedField.orderField == Order.desc)
                            strokaitoga += " DESC ";
                        else
                            strokaitoga += " ASC ";
                        strokaitoga += ", ";
                    }
                }
                strokaitoga = strokaitoga.Remove(strokaitoga.Length - 2, 1);
            }
            strokaitoga += " ;";

            return strokaitoga;
        }//norm

        private void btWatchQuery_Click(object sender, EventArgs e)//норм показать код
        {           
            MessageBox.Show(getsqlkodToShow());
        }

        //dвывполнение запросаа
        private void btExecQuery_Click(object sender, EventArgs e)
        {
            string orderstring = "order by ";
            bool haorderstring = false;
            if (selfield.Count == 0) MessageBox.Show(" поля не выбраны!");
           
            else
            {
                try
                {
                    DataTable table = new DataTable();
                                     
                    using (var sConn = new NpgsqlConnection(_sConnStr))
                    {
                        sConn.Open();
                        var command = new NpgsqlCommand
                        {
                            Connection = sConn,
                            CommandText = getsqlkod()
                        };

                        int index_condition = 0;
                        foreach(var ssss in vira)
                        {
                            string fil_type = ssss.fiel.type_f;

                            if (  fil_type == "varchar" || fil_type == "text"||fil_type == "character varying" ||
                                fil_type == "character" ||fil_type == "char" )
                                command.Parameters.AddWithValue("@" + index_condition.ToString(), ssss.value);
                            

                            index_condition++;
                        }

                        
                        if(haorderstring)orderstring=orderstring.Remove(orderstring.Length-2);

                        NpgsqlDataReader reader = command.ExecuteReader();
                        table.Load(reader);                       
                    }
                    

                    dgvitog.DataSource = table;

                    //изменяем реальные названия столбцов на пользовательские
                    int i = 0;
                    foreach (DataGridViewColumn column in dgvitog.Columns)
                    {
                        column.HeaderText = selfield[i].translit;
                        i++;
                    }
                    MessageBox.Show("Запрос успешно выполнен!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
                
            }        
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        { 
        }
        #region order
        //вкладка сортировки
        // кнопка >
        private void button1_Click(object sender, EventArgs e)
        {
            int i = notselord.SelectedIndex;
            if (i != -1)
            {
                selfielord.Add(unselfielord[i]);
                unselfielord.RemoveAt(i);
            }
            InitializeInterface();
        }
        //кнопка >>
        private void button3_Click(object sender, EventArgs e)
        {
            selfielord.Clear();
            selfielord.AddRange(unselfielord);
            unselfielord.Clear();

            InitializeInterface();
        }
        //ryjgrf <
        private void button2_Click(object sender, EventArgs e)
        {
            int i = lvord_sel.SelectedIndex;
            if (i != -1)
            {
                selfielord[i].orderField = Order.no;
                unselfielord.Add(selfielord[i]);

                selfielord.RemoveAt(i);
            }
            InitializeInterface();
        }
        //ryjgrf <<
        private void button4_Click(object sender, EventArgs e)
        {
            unselfielord.AddRange(selfielord);
            foreach(var nosel in selfielord)
            {
                nosel.orderField = Order.no;
            }
            selfielord.Clear();
            InitializeInterface();
        }

        private void rbVozr_CheckedChanged(object sender, EventArgs e)// радио батон на возрастание 
        {
            int i = lvord_sel.SelectedIndex;
            if (i != -1)
            {
                selfielord[i].orderField = Order.asc;
            }
            else
            {
                MessageBox.Show("Не выбран элемент из списка полей для сортировки");
            }
        }

        private void rbYbivanie_CheckedChanged(object sender, EventArgs e) //радиобатон на убывание
        {
            int i = lvord_sel.SelectedIndex;
            if (i != -1)
            {
                selfielord[i].orderField = Order.desc;
            }
            else
            {
                MessageBox.Show("Не выбран элемент из списка полей для сортировки");
            }
        }

        private void lbSelectedFieldsForOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lvord_sel.SelectedIndex;
            if (i != -1)
            {
                if (selfielord[i].orderField == Order.asc)
                {
                    rbYbivanie.Checked = false;
                    rbNot.Checked = false;
                    rbVozr.Checked = true;
                    return;
                }
                if(selfielord[i].orderField == Order.desc)
                {
                    rbNot.Checked = false;
                    rbVozr.Checked = false;
                    rbYbivanie.Checked = true;
                }
                if (selfielord[i].orderField == Order.no)
                {

                    rbVozr.Checked = false;
                    rbYbivanie.Checked = false;
                    rbNot.Checked = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbNot_CheckedChanged(object sender, EventArgs e)
        {
            int i = lvord_sel.SelectedIndex;
            if (i != -1)
            {
                selfielord[i].orderField = Order.no;
            }
            else
            {
                MessageBox.Show("Не выбран элемент из списка полей для сортировки");
            }
        }

        private void cbExpression_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void notselord_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}





