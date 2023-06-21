using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC
{
    public partial class setSelecter : Form
    {
        public setSelecter()
        {
            InitializeComponent();
        }
        private void setSelecter_Load(object sender, EventArgs e)
        {
            clearButtonText();
            setSeriesImages();

        }
        

        private void clearButtonText()
        {
            baseSetButton.Text = "";
            gymHeroesButton.Text = "";
            neoGenesisButton.Text = "";
            legendaryCollectionButton.Text = "";
            eCardButton.Text = "";
            exRubySapphireButton.Text = "";
            diamondPearlButton.Text = "";
            nintendoPromosButton.Text = "";
            platinumButton.Text = "";
            heartGoldSoulSilverButton.Text = "";
            callOfLegendsButton.Text = "";
            blackWhitePromoButton.Text = "";
            blackWhiteButton.Text = "";
            xYButton.Text = "";
            sunMoonButton.Text = "";
            swordShieldButton.Text = "";
            scarletVioletButton.Text = "";
        }
        private void setSeriesImages()
        {
            string path = Environment.CurrentDirectory;
            string extension = "\\series\\";
            string series = "BS.jpg";
            string filename = path + extension + series;
            System.IO.FileInfo File = new System.IO.FileInfo(filename);
            baseSetButton.BackgroundImage = Image.FromFile(filename);
            series = "GH.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            gymHeroesButton.BackgroundImage = Image.FromFile(filename);
            series = "NG.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            neoGenesisButton.BackgroundImage = Image.FromFile(filename);
            series = "LC.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            legendaryCollectionButton.BackgroundImage = Image.FromFile(filename);
            series = "e-C.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            eCardButton.BackgroundImage = Image.FromFile(filename);
            series = "EXR&S.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            exRubySapphireButton.BackgroundImage = Image.FromFile(filename);
            series = "D&P.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            diamondPearlButton.BackgroundImage = Image.FromFile(filename);
            series = "NP.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            nintendoPromosButton.BackgroundImage = Image.FromFile(filename);
            series = "P.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            platinumButton.BackgroundImage = Image.FromFile(filename);
            series = "HG&SS.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            heartGoldSoulSilverButton.BackgroundImage = Image.FromFile(filename);
            series = "CoL.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            callOfLegendsButton.BackgroundImage = Image.FromFile(filename);
            series = "B&WP.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            blackWhitePromoButton.BackgroundImage = Image.FromFile(filename);
            series = "B&W.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            blackWhiteButton.BackgroundImage = Image.FromFile(filename);
            series = "X&Y.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            xYButton.BackgroundImage = Image.FromFile(filename);
            series = "S&M.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            sunMoonButton.BackgroundImage = Image.FromFile(filename);
            series = "S&S.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            swordShieldButton.BackgroundImage = Image.FromFile(filename);
            series = "S&V.jpg";
            filename = path + extension + series;
            File = new System.IO.FileInfo(filename);
            scarletVioletButton.BackgroundImage= Image.FromFile(filename);

        }
    }
}
