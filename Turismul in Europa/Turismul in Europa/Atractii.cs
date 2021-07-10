using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Turismul_in_Europa
{
    public partial class Atractii : Form
    {
        public Atractii()
        {
            InitializeComponent();
        }

        private void Atractii_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("colosseum.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = Image.FromFile("panteon.jpg");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            label1.Text = "    Colosseumul este un monument turistic aflat in centrul Romei vizitat de foarte mulți turiști din toată lumea. El este probabil cea mai impresionantă clădire-ruină a Imperiului Roman. Colosseumul era cea mai mare construcție a vremurilor sale și astăzi este cel mai mare amfiteatru antic care poate fi vizitat in Italia. Colosseumul este situat la est de Forumul Roman. Colosseumul ar putea avea, estimativ, între 50.000 și 80.000 de spectatori având o audiență medie de aproximativ 65.000.";
            label2.Text = "    Panteonul, o clădire din Roma (Italia), comandat de Marcus Agrippa ca un templu pentru toți zeii din Roma antică, și reconstruit de împăratul Hadrian, în aproximativ 126 d.Hr. Clădirea a fost construită inițial ca templu pentru cele șapte zeități guvernatoare ale celor șapte planete în statul religios al Romei Antice, din secolul al VII-lea fiind transformată într-o biserică creștină. Este cea mai bine conservată clădire romană și cea mai importantă clădire veche din lume cu acoperișul original intact. Deși identitatea arhitectului rămâne incertă, mulți o atribuie lui Apolodor din Damasc.";
        }

        private void Roma_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("colosseum.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = Image.FromFile("panteon.jpg");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            label1.Text = "    Colosseumul este un monument turistic aflat in centrul Romei vizitat de foarte mulți turiști din toată lumea. El este probabil cea mai impresionantă clădire-ruină a Imperiului Roman. Colosseumul era cea mai mare construcție a vremurilor sale și astăzi este cel mai mare amfiteatru antic care poate fi vizitat in Italia. Colosseumul este situat la est de Forumul Roman. Colosseumul ar putea avea, estimativ, între 50.000 și 80.000 de spectatori având o audiență medie de aproximativ 65.000.";
            label2.Text = "    Panteonul, o clădire din Roma (Italia), comandat de Marcus Agrippa ca un templu pentru toți zeii din Roma antică, și reconstruit de împăratul Hadrian, în aproximativ 126 d.Hr. Clădirea a fost construită inițial ca templu pentru cele șapte zeități guvernatoare ale celor șapte planete în statul religios al Romei Antice, din secolul al VII-lea fiind transformată într-o biserică creștină. Este cea mai bine conservată clădire romană și cea mai importantă clădire veche din lume cu acoperișul original intact. Deși identitatea arhitectului rămâne incertă, mulți o atribuie lui Apolodor din Damasc.";
        }

        private void Venetia_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("basilica.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = Image.FromFile("p-dogilor.jpg");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            label1.Text = "    Bazilica Sfântul Marcu (în italiană Basilica di San Marco) este cea mai mare dintre bisericile Veneției, fiind totodată un exemplu elocvent de arhitectură bizantină. Bazilica este închinată personajului biblic Marcu. Este cunoscută și sub denumirea de Domul din Veneția, fiind catedrala patriarhală a acestui oraș. Catedrala este situată în piața cu același nume (Piazza San Marco), aflându-se alături de Palatul Dogilor.";
            label2.Text = "    Palatul Ducal, denumit anterior Palatul Dogilor pentru că acolo era sediul dogilor, simbol al orașului Veneția și capodoperă a goticului venețian, este o clădire monumentală care se află în Piața San Marco, în sestiere San Marco, între piazzetta omonimă și molo di Palazzo Ducale, lângă Bazilica San Marco. ";
        }

        private void Paris_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("eiffel.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = Image.FromFile("luvru.jpg");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            label1.Text = "    Turnul Eiffel este o construcție faimoasă pe schelet de oțel din Paris ce măsoară 324 m înălțime. Turnul a devenit simbolul Franței cel mai răspândit la nivel mondial. A fost conceput de către Émile Nouguier, Maurice Koechlin și Stephen Sauvestre, angajați la Eiffel și Co. Gustave Eiffel, inițial reticent cu privire la proiect, a devenit ulterior un mare susținător al său și a cumpărat brevetul. Turnul, care poartă numele său, este una dintre principalele destinații turistice ale Parisului și lumii, cu mai mult de 5,5 milioane de vizitatori anual. Turnul și-a primit cel de-al 200.000.000 vizitator la 28 noiembrie 2002.";
            label2.Text = "    Muzeul Luvru (în franceză Musée du Louvre) este cel mai mare muzeu de istorie și artă din Franța (după suprafață, 210.000 m2 dintre care 60.600 m2 destinați expozițiilor) și unul dintre cele mai importante muzee din lume. Este situat în centrul capitalei franceze, Paris, între cheiul drept al Senei și strada Rivoli, în primul arondisment, într-o clădire istorică, fost palat regal, Palatul Luvru. Exponatele de artă franțuzești acoperă o largă parte din istoria Franței, de la Dinastia Capețienilor până în prezent.";
        }

        private void Londra_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("big-ben.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = Image.FromFile("roata.jpg");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            label1.Text = "    Big Ben (în traducere, Marele Ben) este porecla marelui clopot al ceasului din turnul de nord al Palatului Westminster din Londra. Acest nume a fost utilizat atât în cazul clopotului, cât și al ceasului și chiar al turnului cu ceas. Big Ben este cel mai mare ceas cu clopot și patru fețe, și al treilea turn cu ceas ca înălțime din lume. Ceasul a fost pus în funcțiune în ziua de 31 mai 1859. Cea mai apropiată stație de metrou este Westminster de pe liniile Circle, District și Jubilee. ";
            label2.Text = "   Roata din Londra, cunoscută sub numele de ''Ochiul Londrei'' reprezintă o roată gigant de observație din Londra aflată în Grădinile Jubilee de pe malul sudic al râului Tamisa. Acesta este in prezent cea mai înaltă roată din Europa, și a oferit cel mai înalt punct vizualizare publică la Londra. Este cea mai populară atracție turistică plătit în Regatul Unit, cu peste 3,5 milioane de vizitatori anual și a făcut multe apariții în cultura populară. ";
        }

        private void Barcelona_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("sagrada.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = Image.FromFile("parc.jpg");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            label1.Text = "   Sagrada Família (Sfânta Familie) este o biserică din capitala Cataloniei, Barcelona (în nord-estul Spaniei). Imensa clădire este încă neterminată, deși se lucrează la ea din 1882. Aceasta nu este finanțată din bani publici, așa cum se obișnuia în Evul Mediu. Sursele de finanțare sunt donațiile private și încasările din biletele de intrare. Bugetul pentru anul 2009 se apropie de 20 milioane de euro. Numele oficial este Temple Expiatori de la Sagrada Família.";
            label2.Text = "   Parcul Güell este un parc cu elemente arhitectonice deosebite, situat în partea superioară a colinei El Carmel în districtul Gracia al Barcelonei, Catalonia, Spania. A fost proiectat de arhitectul Antonio Gaudí și construit între anii 1900 - 1914. Se află din 1984 printre locurile din patrimoniul mondial UNESCO. Parcul se întinde pe o suprafață de 17.18 hectare. Designul arată în mod clar o parte a unui arhitect și stilul unic al lui Gaudi care rezultă evident din oricare element indiferent de dimensiunile acestuia. Există forme ondulate de parcă ar fi râuri de lavă, pasaje acoperite cu coloane de forma unor copaci, stalactite și forme geometrice. Multe din suprafețele existente sunt acoperite cu bucăți de ceramică sau sticlă colorate în stil mozaic numit Trencadis. ";
        }

        private void Atena_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("acropola.jpg");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImage = Image.FromFile("parteon.jpg");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            label1.Text = "   Acropola din Atena, colina sacră fortificată din centrul orașului, este cea mai cunoscută acropolă din lume. A adăpostit, încă din cele mai vechi timpuri, principalele edificii de cult ale Atenei. Distrusă în întregime de către perși în timpul războaielor medice, ea a fost reconstruită în perioada secolului de aur al lui Pericle (secolul al V-lea î.Hr.). La realizarea acesteia au participat arhitecți renumiți ca: Ictinios, Callicrates, Mnesicles, precum și sculptori aflați sub conducerea lui Fidias. Monumentele mai importante de pe Acropole sunt templele Partenon și Erechtheion⁠, ambele dedicate zeiței Atena. ";
            label2.Text = "   Partenonul este un templu în stil doric, alcătuit dintr-o 'cella', în care era păstrată statuia zeiței Atena, din pronaos și 'opistodom' (tezaur), întregul edificiu fiind înconjurat de coloane. Construit din marmură de Pentelic, Partenonul era bogat decorat cu reliefuri realizate de Fidias și de colaboratorii săi. Statuia zeiței, opera lui Phidias, înaltă de 12 m., era realizată din aur și din fildeș; frontonul de răsărit reprezenta nașterea Atenei, iar cel de apus disputa dintre Poseidon și Atena pentru stăpânirea Aticii. ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
