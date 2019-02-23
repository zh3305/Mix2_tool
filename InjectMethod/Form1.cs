using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace InjectMethod
{
    public partial class Form1 : Form
    {
        static string appPath = @"D:\My Documents\Desktop\Assembly-CSharp.dll";
        static string injPath = @"FyLab.dll"; //@"D:\InjectedDLL.dll";
        static string HHPath = @"UintyEngineGUIPatch.dll"; //@"D:\InjectedDLL.dll";

        static string HHTypeName = "TxtInjection";
        static string HHMethodName = "Cjj";

        static string appTypeName = "Chat_Add";
        static string appMethodName = "Add_String";

        static string injTypeName = "Class1";
        static string injMethodName = "Add_String";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //backup
            string appOrigPath = appPath + ".orig";
            File.Copy(appPath, appOrigPath, true);
            File.Copy(injPath, Path.GetDirectoryName(appOrigPath)+@"\"+ injPath, true);

            //get Assemblies
            var app = AssemblyDefinition.ReadAssembly(appOrigPath);
            var inj = AssemblyDefinition.ReadAssembly(injPath);


            var injType = inj.MainModule.Types.Single(t => t.Name == injTypeName);
            var injMethod = injType.Methods.Single(t => t.Name == injMethodName);
            //MethodDefinition myHook = app.MainModule.GetType("HookNamespace.MyHookClass").GetMethod("MyHook");
            // assembiy.MainModule.Import(typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) })))); 

            var appType = app.MainModule.Types.Single(t => t.Name == appTypeName);
            //var appMethod = appType.Methods.Single(t => t.Name == appMethodName);
            var appMethod = appType.Methods.Single(m => { return m.Name == appMethodName && m.Parameters.Count == 3; });



            var ipl = appMethod.Body.GetILProcessor();
            var firstInstruction = ipl.Body.Instructions[0];

            var instruction = ipl.Create(OpCodes.Call, app.MainModule.Import(injMethod.Resolve())); // This instruction is our instruction call

            ipl.InsertBefore(firstInstruction, ipl.Create(OpCodes.Nop)); 
            ipl.InsertBefore(firstInstruction, ipl.Create(OpCodes.Ldarg_1));
            ipl.InsertBefore(firstInstruction, ipl.Create(OpCodes.Ldarga_S, appMethod.Parameters[1]));
            ipl.InsertBefore(firstInstruction, ipl.Create(OpCodes.Ldarga_S, appMethod.Parameters[2]));

            ipl.InsertBefore(firstInstruction, instruction);
            app.Write(appPath);
            Msg_tb.AppendText(string.Format("{0}.{1}   在线翻译注入完成!!-------\r\n", appTypeName, appMethodName));

            //Instruction ins = appMethod.Body.Instructions[0];
            //var worker = appMethod.Body.GetILProcessor();
            //MethodInfo m = typeof(Program).GetMethod("InjectMethod", BindingFlags.Static | BindingFlags.Public);
            //MethodReference refernce = app.MainModule.Import(m);
            //Instruction insCall = worker.Create(OpCodes.Call, refernce);
            //worker.InsertBefore(ins, insCall);
            //Instruction insNop = worker.Create(OpCodes.Nop);
            //worker.InsertAfter(insCall, insNop);
        }
        public static void InjectMethod()
        {
            Console.WriteLine("Haha...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择Assembly-CSharp";
            fileDialog.Filter = "Assembly-CSharp|Assembly-CSharp.dll";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                appPath = file;
                label1.Text = file;
               // MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Init_BuffSct_Click(object sender, EventArgs e)
        {

            try
            {
                string appOrigPath = appPath + ".orig";
                //File.Copy(appPath, appOrigPath, true);
                //File.Copy(HHPath, Path.GetDirectoryName(appOrigPath) + @"\" + HHPath, false);
            }
            catch { }

            //get Assemblies
            var app = AssemblyDefinition.ReadAssembly(appPath);
            var inj = AssemblyDefinition.ReadAssembly(HHPath);

           
            var 注入方法 = inj.MainModule.Types.Single(t => t.Name == HHTypeName).Methods.Single(t => t.Name == HHMethodName);

            string appTypeName = "ClientTableMgr";
            string appMethodName = "Init_BuffSct";// Init_BuffSct(string text)

            var appMethod = app.MainModule.Types.Single(t => t.Name == appTypeName).Methods.Single(m => { return m.Name == appMethodName && m.Parameters.Count == 1; });
            
            var ipl = appMethod.Body.GetILProcessor();
            string InCode = "";

            InCode = "szTooltip";
            var firstInstruction = ipl.Body.Instructions.Single(m => { return m.OpCode == OpCodes.Stfld && ((Mono.Cecil.FieldDefinition)m.Operand).Name == InCode; });
            ipl.InsertBefore(firstInstruction, ipl.Create(OpCodes.Call, app.MainModule.Import(注入方法.Resolve())));

            InCode = "szBuffName";
            firstInstruction = ipl.Body.Instructions.Single(m => { return m.OpCode == OpCodes.Stfld && ((Mono.Cecil.FieldDefinition)m.Operand).Name == InCode; });
            ipl.InsertBefore(firstInstruction, ipl.Create(OpCodes.Call, app.MainModule.Import(注入方法.Resolve())));
            app.Write(appPath);
           Console.WriteLine("注入完成!!-------");
            Msg_tb.AppendText("注入完成!!-------");

        }

        public void inthh(string appTypeName, string appMethodName,String InCode,int py=0)
        {
            try
            {
                if(checkBox1.Checked)
                { 
                string appOrigPath = appPath + ".orig";
                File.Copy(appPath, appOrigPath, true);
                File.Copy(HHPath, Path.GetDirectoryName(appOrigPath) + @"\" + HHPath, false);
                }
            }
            catch { }

            //get Assemblies
            var app = AssemblyDefinition.ReadAssembly(appPath);
            var inj = AssemblyDefinition.ReadAssembly(HHPath);


            var injType = inj.MainModule.Types.Single(t => t.Name == HHTypeName);
            var injMethod = injType.Methods.Single(t => t.Name == HHMethodName);


            var appType = app.MainModule.Types.Single(t => t.Name == appTypeName);
            var appMethod = appType.Methods.Single(m => { return m.Name == appMethodName && m.Parameters.Count == 1; });

            var ipl = appMethod.Body.GetILProcessor();
            //var firstInstruction = ipl.Body.Instructions.Single(m => { return m.OpCode == OpCodes.Stfld && ((Mono.Cecil.FieldDefinition)m.Operand).Name.ToLower() == InCode.ToLower(); });
            var firstInstruction = ipl.Body.Instructions.Single(m => { return m.Operand!=null&& m.Operand.GetType() == typeof(FieldDefinition) && ((FieldDefinition)m.Operand).Name.ToLower() == InCode.ToLower(); });

            if (py != 0)
            {
                firstInstruction = ipl.Body.Instructions[ipl.Body.Instructions.IndexOf(firstInstruction) + py];
            }
            ipl.InsertBefore(firstInstruction, ipl.Create(OpCodes.Call, app.MainModule.Import(injMethod.Resolve())));
           
            app.Write(appPath);
            Console.WriteLine(string.Format("{0}.{1} {2}  注入完成!!-------\r\n", appTypeName, appMethodName, InCode));
            Msg_tb.AppendText(string.Format("{0}.{1} {2}  注入完成!!-------\r\n", appTypeName, appMethodName, InCode));
        }
   

        private void button3_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_NpcModel", "npcName");
            inthh("ClientTableMgr", "Init_NpcModel", "npc_printName");
            inthh("ClientTableMgr", "Init_NpcModel", "dialogue");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_SkillTooltipSct", "szSkillName");
            inthh("ClientTableMgr", "Init_SkillTooltipSct", "szTooltip");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_StringTable", "text");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_Table_Hench_Base", "szName");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_NpcGroupName", "dic_NpcGroupName",-2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_MapSct", "szMapName");
            inthh("ClientTableMgr", "Init_MapSct", "list_MapText",-1);
            inthh("ClientTableMgr", "Init_MapSct", "list_Tip", -1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_SkillBase", "name");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_WarpMachine", "szMapName");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_Luridia_QuestSct", "szQuestName");
            inthh("ClientTableMgr", "Init_Luridia_QuestSct", "szNpcName");
            inthh("ClientTableMgr", "Init_Luridia_QuestSct", "szStart_Dialogue");
            inthh("ClientTableMgr", "Init_Luridia_QuestSct", "szEnd_dialogue");
            inthh("ClientTableMgr", "Init_Luridia_QuestSct", "szOnDialogue");
            inthh("ClientTableMgr", "Init_Luridia_QuestSct", "szQuest_Summary");
            inthh("ClientTableMgr", "Init_Luridia_QuestSct", "szGoal_1");
            inthh("ClientTableMgr", "Init_Luridia_QuestSct", "szGoal_2");
            inthh("ClientTableMgr", "Init_Luridia_QuestSct", "szGoal_3");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_HenchBookSkill", "szTooltip");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_MonsterModel", "monsterName");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_Dungeon", "szMapName");
            inthh("ClientTableMgr", "Init_Dungeon", "szDungeonText");
            inthh("ClientTableMgr", "Init_Dungeon", "szPopUpMsg");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_ItemSct_Tab", "szItemName");
            inthh("ClientTableMgr", "Init_ItemSct_Tab", "szTooltip",-7);

        }

        private void Init_WorldmapIcon_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_WorldmapIcon", "szPrintName");

        }

        private void Init_HenchBook_Click(object sender, EventArgs e)
        {
            inthh("ClientTableMgr", "Init_HenchBook", "szName");
            inthh("ClientTableMgr", "Init_HenchBook", "szHenchStory");
        }

        private void CreateMonster_Click(object sender, EventArgs e)
        {

            inthh("MonsterManager", "CreateMonster", "monsterName");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //string assemblyPath = $"{Environment.CurrentDirectory}\\ClassLibrary1.dll";
        //var mainModule = AssemblyDefinition.ReadAssembly(assemblyPath).MainModule;

        //var methodDef = mainModule.Types.First(
        //    type => type.Name == "TestClass").Methods.Single(m => m.Name == "TestMethod");

        //var eq = mainModule.Import(typeof(EqualityComparer<>));
        //var obj = mainModule.Import(typeof(object));
        //var genericEq = new GenericInstanceType(eq);
        //genericEq.GenericArguments.Add(obj);
        //var importedGenericEq = mainModule.Import(genericEq);
        //var defaultMethodDef = importedGenericEq.Resolve().Methods.Single(m => m.Name == "get_Default");
        //var methodRef = mainModule.Import(defaultMethodDef);
        //methodRef.DeclaringType = importedGenericEq;

        //var ilProcessor = methodDef.Body.GetILProcessor();
        //ilProcessor.InsertBefore(
        //    ilProcessor.Body.Instructions.First(),
        //    Instruction.Create(OpCodes.Callvirt, methodRef));
        //methodDef.Body.OptimizeMacros();

        //mainModule.Write(assemblyPath + ".new.dll");

        //var readerParameters = new ReaderParameters { ReadSymbols = true };
        //var assemblyDefinition = AssemblyDefinition.ReadAssembly(fileName, readerParameters);
        //// make required changes.
        //var writerParameters = new WriterParameters { WriteSymbols = true };
        //assemblyDefinition.Write(outputFile, writerParameters);

        //var method = GetMethodDefinition(...);
        //var il = method.Body.GetILProcessor();
        //var ldstr = il.Create(OpCodes.Ldstr, method.Name);
        //var call = il.Create(OpCodes.Call,
        //    method.Module.Import(
        //        typeof(Console).GetMethod("WriteLine", new[] { typeof(string) })));
        //il.InsertBefore(method.Body.Instructions[0], ldstr);
        //il.InsertAfter(method.Body.Instructions[0], call);

        //}
    }
}
