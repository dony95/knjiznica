using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica
{
    public partial class IzvjestajForma : Form
    {
        FilterDefinitionBuilder<BsonDocument> filterBuilder;
        public IzvjestajForma()
        {
            InitializeComponent();
            cb_startDTknjige.Value = DateTime.Now.AddDays(-7);
            cb_startDTprijave.Value = DateTime.Now.AddDays(-7);
            cb_startDTknjige.MaxDate = DateTime.Now;
            cb_startDTprijave.MaxDate = DateTime.Now;
            cb_endDTknjige.MaxDate = DateTime.Now;
            cb_endDTprijave.MaxDate = DateTime.Now;
            filterBuilder = Builders<BsonDocument>.Filter;
        }

        private void btn_logPrijave_Click(object sender, EventArgs e)
        {
            var filter = filterBuilder.Gt("datumIvrijeme", cb_startDTprijave.Value.ToString("dd.MM.yyyy HH:mm"))
                         & filterBuilder.Lte("datumIvrijeme", cb_endDTprijave.Value.ToString("dd.MM.yyyy HH:mm"));
            var kolekcija = MainWindow.mongoClient.GetDatabase("knjiznica").GetCollection<BsonDocument>("login");
            var dokumenti = kolekcija.Find(filter).ToList();

            foreach (var dokument in dokumenti)
            {
                tb_prijave.AppendText("Info: " + dokument["info"] + "\n");
                tb_prijave.AppendText("Datum i vrijeme: " + dokument["datumIvrijeme"] + Environment.NewLine);
                tb_prijave.AppendText(Environment.NewLine);
            }
        }

        private void btn_logKnjige_Click(object sender, EventArgs e)
        {
            var filter = filterBuilder.Gt("datumIvrijeme", cb_startDTknjige.Value.ToString("dd.MM.yyyy HH:mm"))
                         & filterBuilder.Lte("datumIvrijeme", cb_endDTknjige.Value.ToString("dd.MM.yyyy HH:mm"));
            var kolekcija = MainWindow.mongoClient.GetDatabase("knjiznica").GetCollection<BsonDocument>("knjige");
            var dokumenti = kolekcija.Find(filter).ToList();

            foreach (var dokument in dokumenti)
            {
                tb_knjige.AppendText("Info: " + dokument["info"] + "\n");
                tb_knjige.AppendText("Datum i vrijeme: " + dokument["datumIvrijeme"] + Environment.NewLine);
                tb_knjige.AppendText(Environment.NewLine);
            }
        }
    }
}
