using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 加载命名空间
using System.Drawing.Text;
using System.IO;

namespace 记事本
{
    public partial class FrmChild : Form
    {
        //记录当前打开文件路径
        private string _filePath = string.Empty;

        public FrmChild()
        {
            InitializeComponent();
        }

        // 窗体加载事件
        private void FrmChild_Load(object sender, EventArgs e)
        {
            // 窗体加载时加载系统字体
            InstalledFontCollection myFonts = new InstalledFontCollection();
            // 获取InstalledFontCollection对象数组
            FontFamily[] ff = myFonts.Families;

            HashSet<string> fontSet = new HashSet<string>();
            // 循环把字体写入控件
            foreach (var family in ff)
            {
                if (!fontSet.Contains(family.Name))
                {
                    fontSet.Add(family.Name);
                    toolStripComboBoxFonts.Items.Add(family.Name);
                }
            }
        }

        // 加粗按钮。加粗是再点击取消加粗
        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            Font currentFont = textBoxNote.Font;
            FontStyle newStyle;
            if (currentFont.Bold)
            {
                newStyle = currentFont.Style & ~FontStyle.Bold;
            }
            else
            {
                newStyle = currentFont.Style | FontStyle.Bold;
            }
            textBoxNote.Font = new Font(currentFont, newStyle);
        }

        // 倾斜按钮
        private void toolStripButtonItaick_Click(object sender, EventArgs e)
        {
            Font currentFont = textBoxNote.Font;
            FontStyle newStyle;
            if (currentFont.Italic)
            {
                newStyle = currentFont.Style & ~FontStyle.Italic;
            }
            else
            {
                newStyle = currentFont.Style | FontStyle.Italic;
            }
            textBoxNote.Font = new Font(currentFont, newStyle);
        }

        // 改变选择字体的索引事件
        private void toolStripComboBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontAndSize();
        }

        // 改变字号
        private void toolStripComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontAndSize();
        }

        private void toolStripComboBoxSize_TextChanged(object sender, EventArgs e)
        {
            ChangeFontAndSize();
        }

        /// <summary>安全修改字体字号，防止程序崩溃</summary>
        private void ChangeFontAndSize()
        {
            string fontName = toolStripComboBoxFonts.Text?.Trim();
            if (string.IsNullOrWhiteSpace(fontName))
                return;

            if (!float.TryParse(toolStripComboBoxSize.Text, out float fontSize))
                return;

            if (fontSize <= 0 || fontSize > 500)
                return;

            try
            {
                textBoxNote.Font = new Font(fontName, fontSize, textBoxNote.Font.Style);
            }
            catch
            {
                //无效字体直接忽略
            }
        }

        // 保存文档
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNote.Text))
            {
                MessageBox.Show("空文档不能保存", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (string.IsNullOrEmpty(_filePath))
                {
                    // 路径选择
                    // 创建筛选器
                    saveFileDialog1.Filter = "文本文档(*.txt)|*.txt";
                    // 判断点击的保存按钮还是取消
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        _filePath = saveFileDialog1.FileName;
                        Console.WriteLine(_filePath);
                        // 保存文件到用户指定目录位置
                        WriteFile(_filePath, textBoxNote.Text);
                        this.Text = _filePath;
                    }
                }
                else
                {
                    // 保存文件到用户指定目录位置
                    // 获取用户选择文件及路径
                    Console.WriteLine(_filePath);
                    WriteFile(_filePath, textBoxNote.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //写文件辅助方法
        private void WriteFile(string path, string content)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.Write(content);
            }
        }

        // 打开文档
        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            // 创建筛选器
            openFileDialog1.Filter = "文本文档(*.txt)|*.txt";
            // 判断点击的保存按钮还是取消
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 获取打开文档的路径
                    string path = openFileDialog1.FileName;
                    Console.WriteLine(path);
                    // 通用编码
                    using (StreamReader sr = new StreamReader(path, Encoding.Default))
                    {
                        // 获取选中的数据流
                        string text = sr.ReadToEnd();// 读取全部
                        textBoxNote.Text = text;
                        _filePath = path;
                        this.Text = _filePath;
                        // 把文件路径到窗体text属性中 清空
                        toolStripLabelMake.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"打开文件失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
