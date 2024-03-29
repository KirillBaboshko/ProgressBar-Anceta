﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProgressBar_Anceta
{
    public partial class Form1 : Form
    {
        static string text = "Соображения высшего порядка, а также реализация намеченного плана развития требует от нас анализа ключевых компонентов планируемого обновления. Практический опыт показывает, что курс на социально-ориентированный национальный проект обеспечивает актуальность ключевых компонентов планируемого обновления. Соображения высшего порядка, а также консультация с профессионалами из IT способствует подготовке и реализации существующих финансовых и административных условий!\r\n\r\nНе следует, однако, забывать о том, что рамки и место обучения кадров напрямую зависит от дальнейших направлений развития проекта. Повседневная практика показывает, что начало повседневной работы по формированию позиции создаёт предпосылки качественно новых шагов для новых предложений. С другой стороны начало повседневной работы по формированию позиции требует определения и уточнения дальнейших направлений развития проекта? Повседневная практика показывает, что дальнейшее развитие различных форм деятельности требует определения и уточнения дальнейших направлений развития проекта.\r\n\r\nРазнообразный и богатый опыт новая модель организационной деятельности представляет собой интересный эксперимент проверки направлений прогрессивного развития. Дорогие друзья, консультация с профессионалами из IT влечет за собой процесс внедрения и модернизации дальнейших направлений развитая системы массового участия. Значимость этих проблем настолько очевидна, что сложившаяся структура организации влечет за собой процесс внедрения и модернизации системы обучения кадров, соответствующей насущным потребностям. Задача организации, в особенности же консультация с профессионалами из IT требует определения и уточнения дальнейших направлений развития проекта?\r\n\r\nС другой...";
        string[] words = text.Split(' ');
        public Form1()
        {
           InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum=words.Count();
            for (int i = 0; i <= words.Count(); i++)
            {
                    progressBar1.Value=i;
                    label1.Text = "Количество слов:" + progressBar1.Value.ToString();
                    this.Update();
                    Thread.Sleep(50);
            }
        }
    }
}
