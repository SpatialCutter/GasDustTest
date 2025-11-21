using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasDustTest
{
    public partial class Form2 : Form
    {
        private int step = 0;
        private Control active;
        private decimal m11, m21, m12, m22;
        private decimal V1, V2;

        public Form2()
        {
            InitializeComponent();            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Label lIntro = new Label();
            lIntro.Text = "Для определения смолы и пыли применяют:\n Счётчик газовый барабанный типа ГСБ-400;\n Трубки хлоркальцевые типов TX-U-2 и TX-U-3 по ГОСТ 22336-82;\n Кальций хлористый гранулированный по НТД;\n Вату гигроскопическую;\n Весы аналитические не ниже 2-го класса.";
            active = lIntro;
            active.Size = pMain.Size;
            pMain.Controls.Add(lIntro);
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            step++;
            pMain.Controls.Clear();
            switch (step)
            {
                case 1:
                    lHeader.Text = "Качественное измерение";
                    active = new UserControls.QualityTest();
                    pMain.Controls.Add(active);
                    break;
                case 2:
                    if ((active as UserControls.QualityTest).check == false)
                    {
                        step = 12;
                        bNext_Click(sender, e);
                        break; //Переход к выводу
                    }
                    lHeader.Text = "Подготовка к количественному измерению";
                    AddLabel("Перед определением содержания смолы и пыли в газе наполните две трубки гигроскопической ватой, третью трубку наполните свежепрокаленным хлористым кальцием. \nЗакройте трубки пробками и соедините в последовательности: вата - хлористый кальций - вата. \nИспытайте на герметичность.");
                    break;
                case 3:
                    lHeader.Text = "Подготовка трубок";
                    AddTimer(1500, "Присоедините первую трубку (с ватой) к газовому счётчику, третью трубку (с ватой) присоедините к газопроводу. \nПропустите через трубки газ в течении 20-30 минут со скоростью 75-80 дм³/ч. \nПо прошествии времени отсоедините трубки от газопровода и счётчика, разъедините друг от друга и закройте.");
                    break;
                case 4:
                case 8:
                    lHeader.Text = "Выдержка трубки";
                    AddTimer(1020, "Выдержите трубку с ватой 15-20 минут.");
                    break;
                case 5:
                    lHeader.Text = "Взвешивание трубки до пропуска газа";
                    AddMassInput("Взвесьте первую трубку (ранее подключенную к газовому счётчику) с погрешностью не более 0,0002 г. \nРезультат взвешивания введите в поле ниже.");
                    break;
                case 6:
                    if (!ZeroCheck((active as UserControls.MassInput).mass, "Масса трубки не может быть равна нулю")) break;
                    if (m11 == 0)
                        m11 = (active as UserControls.MassInput).mass;
                    else
                        m21 = (active as UserControls.MassInput).mass;
                    lHeader.Text = "Пропускание газа, шаг 1";
                    AddLabel("Соедините трубки вместе в той же последовательности (вата - хлористый кальций - вата). \nСоедините первую трубку (взвешенную) к газопроводу, а третью присоедините к газовому счётчику. \nПропустите через трубки не менее 1000 дм³ газа со скоростью 75-80 дм³/ч. \nЗатем выключите газ.");
                    break;
                case 7:
                    lHeader.Text = "Пропускание газа, шаг 2";
                    AddTimer(1500, "Поменяйте местами первую и третью трубки. \nПропустите газ с той же скоростью (75-80 дм³/ч) в течении 20-30 минут. \nПо прошествии времени отсоедините предварительно взвешенную трубку и закройте её.");
                    break;
                case 9:
                    lHeader.Text = "Взвешивание трубки после пропуска газа";
                    AddMassInput("Взвесьте первую трубку (предварительно взвешенную и выдержанную) с погрешностью не более 0,0002 г. \nРезультат взвешивания введите в поле ниже.");
                    break;
                case 10:
                    if (!ZeroCheck((active as UserControls.MassInput).mass, "Масса трубки не может быть равна нулю")) break;
                    if (m12 == 0)
                        m12 = (active as UserControls.MassInput).mass;
                    else
                        m22 = (active as UserControls.MassInput).mass;
                    lHeader.Text = "Ввод объёма газа";
                    AddVolumeInput("Заполните поля ниже, согласно показаниям счётчика.");
                    break;
                case 11:
                    if (!ZeroCheck((active as UserControls.VolumeInput).volume, "Объём газа не может быть равен нулю")) break;
                    if (V1 == 0)
                        V1 = (active as UserControls.VolumeInput).volume;
                    else
                    {
                        V2 = (active as UserControls.VolumeInput).volume;
                        step++;
                        bNext_Click(sender, e);
                        break;
                    }
                    lHeader.Text = "Повторные измерения";
                    AddLabel("За результат испытания принимают среднеарифметическое двух параллельных определений, допускаемые расхождения между которыми не должны превышать 0,05 г. на 100 м³.");
                    break;
                case 12:
                    step = 2;
                    bNext_Click(sender, e);
                    break;
                case 13:
                    lHeader.Text = "Результаты испытаний";
                    UserControls.ResultOutput result = new UserControls.ResultOutput();
                    result.dust1 = result.CalculateDust(m11, m12, V1);
                    result.dust2 = result.CalculateDust(m21, m22, V2);
                    active = result;
                    bNext.Text = "Закрыть";
                    break;
                case 14:
                    this.Close();
                    break;
            }
            active.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            active.Size = pMain.Size;
            pMain.Controls.Add(active);
        }

        private bool ZeroCheck(decimal value, string message)
        {
            if (value == 0)
            {
                step -= 2;
                MessageBox.Show("Масса трубки не может быть равна нулю");
                bNext_Click(bNext, new EventArgs());
                return false;
            }
            return true;
        }

        private void AddLabel(string text)
        {
            Label lGuide = new Label();
            lGuide.Text = text;
            active = lGuide;
        }

        private void AddTimer(int secs, string text)
        {
            UserControls.LabeledTimer timer = new UserControls.LabeledTimer();
            timer.timersecs = secs;
            timer.text = text;
            active = timer;
        }

        private void AddMassInput(string text)
        {
            UserControls.MassInput mass = new UserControls.MassInput();
            mass.text = text;
            active = mass;
        }

        private void AddVolumeInput(string text)
        {
            UserControls.VolumeInput volume = new UserControls.VolumeInput();
            volume.text = text;
            active = volume;
        }
    }
}
