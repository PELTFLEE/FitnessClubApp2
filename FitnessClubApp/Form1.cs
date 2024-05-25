using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace FitnessClubApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(WeightTextBox.Text);
            double height = Convert.ToDouble(HeightTextBox.Text);
            double age = Convert.ToDouble(ageBox.Text);


            List<string> workouts = GenerateWorkoutProgramMan(weight, height, age);
            List<string> workouts2 = GenerateWorkoutProgramWoman(weight, height, age);

            listBox1.Items.Clear();
            listBox1.Items.AddRange(workouts.ToArray());
            listBox1.Items.AddRange(workouts2.ToArray());

        }

        private List<string> GenerateWorkoutProgramMan(double weight, double height, double age)
        {
            List<string> workouts = new List<string>();
            //понедельник
            int pullUp = (int)(weight * 0.03) * (int)(height * 0.05) * (int)(age * 0.08);
            int tiltThrust = (int)(weight * 0.09) * (int)(height * 0.05) * (int)(age * 0.08);
            int deadlift = (int)(weight * 0.09) * (int)(height * 0.05) * (int)(age * 0.08);
            int mahi = (int)(weight * 0.08) * (int)(height * 0.05) * (int)(age * 0.08);
            int bicepsStanding = (int)(weight * 0.09) * (int)(height * 0.05) * (int)(age * 0.08);
            int hammerBends = (int)(weight * 0.08) * (int)(height * 0.05) * (int)(age * 0.08);
            //понедельник

            //среда
            int benchPressWeight = (int)(weight * 0.09) * (int)(height * 0.05) * (int)(age * 0.08);
            int legHorizontalBar = (int)(weight * 0.08) * (int)(height * 0.05) * (int)(age * 0.08);
            int twistingLyingDown = (int)(weight * 0.05) * (int)(height * 0.05) * (int)(age * 0.08);
            int benchPress = (int)(weight * 0.09) * (int)(height * 0.05) * (int)(age * 0.08);
            //среда

            //пятница
            int FrencBenchPress = (int)(weight * 0.09) * (int)(height * 0.05) * (int)(age * 0.08);
            int squatsWeight = (int)(weight * 0.1) * (int)(height * 0.05) * (int)(age * 0.08);
            int legBends = (int)(weight * 0.1) * (int)(height * 0.05) * (int)(age * 0.08);
            int pushupsOnTheUnevenBars = (int)(weight * 0.03) * (int)(height * 0.05) * (int)(age * 0.08);
            int benchPressInTheBlock = (int)(weight * 0.09) * (int)(height * 0.05) * (int)(age * 0.08);

            //пятница
            workouts.Add("Программа тренировок для мужчин:");
            //понедельник
            workouts.Add("Понедельник (Спина/Бицепс) : ");
            workouts.Add("1. Подтягивания с доп. весом: 4 подхода по 10 повторений " + pullUp + "кг ");
            workouts.Add("2. Тяга штанги в наклоне: 4 подхода по 8 повторений " + tiltThrust + "кг ");
            workouts.Add("3. Становая тяга: 3 подхода по 10 повторений " + deadlift + " кг");
            workouts.Add("4. Махи гантелями в наклоне: 3 подхода по 15 повторений " + mahi + " кг");
            workouts.Add("5. Подъем штанги на бицепс стоя: 4 подхода по 8 повторений " + bicepsStanding + " кг");
            workouts.Add("6. Молотковые сгибания: 3 подхода по 8 повторений " + hammerBends + " кг");
            //понедельник
            workouts.Add("");
            //среда
            workouts.Add("Среда (Грудь/Пресс) : ");
            workouts.Add("1. Жим лежа: 4 подхода по 8 повторений " + benchPressWeight + " кг");
            workouts.Add("2. Подъем ног на турнике с доп. весом: 3 подхода по 12 повторений " + legHorizontalBar + "кг ");
            workouts.Add("3. Скручивания лежа с доп. весом: 3 подхода по 15 повторений " + twistingLyingDown + " кг");
            workouts.Add("4. Жим штанги сидя: 4 подхода по 15 повторений " + benchPress + " кг");
            //среда
            workouts.Add("");
            //пятница
            workouts.Add("Пятница (Трицепс/Ноги) : ");
            workouts.Add("1. Французский жим лежа: 3 подхода по 10 повторений " + FrencBenchPress + " кг");
            workouts.Add("2. Приседания со штангой: 4 подхода по 8 повторений " + squatsWeight + " кг");
            workouts.Add("3. Разгибания ног: 3 подхода по 15 повторений " + legBends + " кг");
            workouts.Add("4. Отжимания на брусьях с доп весом: 3 подхода по 10 повторений " + pushupsOnTheUnevenBars + " кг");
            workouts.Add("5. Жим в блочном тренажере: 4 подхода по 8 повторений " + benchPressInTheBlock + " кг");
            //пятница
            workouts.Add("");
            workouts.Add("");
            workouts.Add("");
            workouts.Add("");
            return workouts;
        }

        private List<string> GenerateWorkoutProgramWoman(double weight, double height, double age)
        {
            List<string> workouts2 = new List<string>();
            //понедельник
            int pullUp = (int)(weight * 0.02) * (int)(height * 0.04) * (int)(age * 0.06);
            int tiltThrust = (int)(weight * 0.08) * (int)(height * 0.04) * (int)(age * 0.06);
            int deadlift = (int)(weight * 0.08) * (int)(height * 0.04) * (int)(age * 0.06);
            int mahi = (int)(weight * 0.07) * (int)(height * 0.04) * (int)(age * 0.06);
            int bicepsStanding = (int)(weight * 0.08) * (int)(height * 0.04) * (int)(age * 0.06);
            int hammerBends = (int)(weight * 0.07) * (int)(height * 0.04) * (int)(age * 0.06);
            //понедельник

            //среда
            int benchPressWeight = (int)(weight * 0.08) * (int)(height * 0.04) * (int)(age * 0.06);
            int legHorizontalBar = (int)(weight * 0.07) * (int)(height * 0.04) * (int)(age * 0.06);
            int twistingLyingDown = (int)(weight * 0.04) * (int)(height * 0.04) * (int)(age * 0.06);
            int benchPress = (int)(weight * 0.08) * (int)(height * 0.04) * (int)(age * 0.06);
            //среда

            //пятница
            int FrencBenchPress = (int)(weight * 0.08) * (int)(height * 0.04) * (int)(age * 0.06);
            int squatsWeight = (int)(weight * 0.09) * (int)(height * 0.04) * (int)(age * 0.06);
            int legBends = (int)(weight * 0.09) * (int)(height * 0.04) * (int)(age * 0.06);
            int pushupsOnTheUnevenBars = (int)(weight * 0.02) * (int)(height * 0.04) * (int)(age * 0.06);
            int benchPressInTheBlock = (int)(weight * 0.08) * (int)(height * 0.04) * (int)(age * 0.06);

            //пятница
            workouts2.Add("Программа тренировок для женщин:");
            //понедельник
            workouts2.Add("Понедельник (Спина/Бицепс) : ");
            workouts2.Add("1. Подтягивания с доп. весом: 4 подхода по 10 повторений " + pullUp + "кг ");
            workouts2.Add("2. Тяга штанги в наклоне: 4 подхода по 8 повторений " + tiltThrust + "кг ");
            workouts2.Add("3. Становая тяга: 3 подхода по 10 повторений " + deadlift + " кг");
            workouts2.Add("4. Махи гантелями в наклоне: 3 подхода по 15 повторений " + mahi + " кг");
            workouts2.Add("5. Подъем штанги на бицепс стоя: 4 подхода по 8 повторений " + bicepsStanding + " кг");
            workouts2.Add("6. Молотковые сгибания: 3 подхода по 8 повторений " + hammerBends + " кг");
            //понедельник
            workouts2.Add("");
            //среда
            workouts2.Add("Среда (Грудь/Пресс) : ");
            workouts2.Add("1. Жим лежа: 4 подхода по 8 повторений " + benchPressWeight + " кг");
            workouts2.Add("2. Подъем ног на турнике с доп. весом: 3 подхода по 12 повторений " + legHorizontalBar + "кг ");
            workouts2.Add("3. Скручивания лежа с доп. весом: 3 подхода по 15 повторений " + twistingLyingDown + " кг");
            workouts2.Add("4. Жим штанги сидя: 4 подхода по 15 повторений " + benchPress + " кг");
            //среда
            workouts2.Add("");
            //пятница
            workouts2.Add("Пятница (Трицепс/Ноги) : ");
            workouts2.Add("1. Французский жим лежа: 3 подхода по 10 повторений " + FrencBenchPress + " кг");
            workouts2.Add("2. Приседания со штангой: 4 подхода по 8 повторений " + squatsWeight + " кг");
            workouts2.Add("3. Разгибания ног: 3 подхода по 15 повторений " + legBends + " кг");
            workouts2.Add("4. Отжимания на брусьях с доп весом: 3 подхода по 10 повторений " + pushupsOnTheUnevenBars + " кг");
            workouts2.Add("5. Жим в блочном тренажере: 4 подхода по 8 повторений " + benchPressInTheBlock + " кг");
            //пятница
            workouts2.Add("");
            workouts2.Add("");
            workouts2.Add("");
            workouts2.Add("");
            return workouts2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Текстовые файлы|*.txt";
            saveFileDialog1.Title = "Сохранить программу тренировок";
            saveFileDialog1.FileName = "Тренировка_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (var item in listBox1.Items)
                    {
                        file.WriteLine(item.ToString());
                    }
                }

                MessageBox.Show("Программа тренировок успешно сохранена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
