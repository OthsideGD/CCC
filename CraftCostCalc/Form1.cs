using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CraftCostCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Класс для сохранения переменных

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //--------------------------------------
            //Подсчет цены крафтовые ресурсы

                //Перевод Стринг в Инт для базовых ресурсов
            double AdamantiteNugget, AnimalBone, AnimalSkin, Asofe, Charcoal, Coal,
            Enria, IronOre, MithrilOre, MoldGlue, MoldHardener, MoldLubricant,
            OriharukonOre, SilverNugget, Stem, StoneOfPurity, Suede, Thons, Thread,
            Varnish, Cry_d, Cry_c, Cry_b, Cry_a, Cry_s, Gem_d, Gem_c, Gem_b, Gem_a, Gem_s;

            double.TryParse(TBAdamantiteNugget.Text, out AdamantiteNugget);
            double.TryParse(TBAnimalBone.Text, out AnimalBone);
            double.TryParse(TBAnimalSkin.Text, out AnimalSkin);
            double.TryParse(TBAsofe.Text, out Asofe);
            double.TryParse(TBCharcoal.Text, out Charcoal);
            double.TryParse(TBCoal.Text, out Coal);
            double.TryParse(TBEnria.Text, out Enria);
            double.TryParse(TBIronOre.Text, out IronOre);
            double.TryParse(TBMithrilOre.Text, out MithrilOre);
            double.TryParse(TBMoldGlue.Text, out MoldGlue);
            double.TryParse(TBMoldHardener.Text, out MoldHardener);
            double.TryParse(TBMoldLubricant.Text, out MoldLubricant);
            double.TryParse(TBOriharukonOre.Text, out OriharukonOre);
            double.TryParse(TBSilverNugget.Text, out SilverNugget);
            double.TryParse(TBStem.Text, out Stem);
            double.TryParse(TBStoneOfPurity.Text, out StoneOfPurity);
            double.TryParse(TBSuede.Text, out Suede);
            double.TryParse(TBThons.Text, out Thons);
            double.TryParse(TBThread.Text, out Thread);
            double.TryParse(TBVarnish.Text, out Varnish);
            double.TryParse(TBCry_d.Text, out Cry_d);
            double.TryParse(TBCry_c.Text, out Cry_c);
            double.TryParse(TBCry_b.Text, out Cry_b);
            double.TryParse(TBCry_a.Text, out Cry_a);
            double.TryParse(TBCry_s.Text, out Cry_s);
            double.TryParse(TBGem_d.Text, out Gem_d);
            double.TryParse(TBGem_c.Text, out Gem_c);
            double.TryParse(TBGem_b.Text, out Gem_b);
            double.TryParse(TBGem_a.Text, out Gem_a);
            double.TryParse(TBGem_s.Text, out Gem_s);

                //Крафтовые ресурсы
            double BraidedHemp, CoarsedBonePowder, Cokes, CompoundBraid, HighGradeSuede, Leather, MetalHardener, MetallicThread, DurableMetalPlate, Steel, Cord, MetallicFiber,
            CraftedLeather, SteelMold, SyntheticCokes, Oriharukon, VarnishOfPurity,MithrilAlloy, SilverMold, BlacksmithsFrame, ArtisansFrame, CraftsmanMold,
            ArcsmithsAnvil, MaestroAnvilLock, LeolinsMold, MaestroHolder, MaestroMold, WarsmithsHolder, WarsmithsMold;
             

            //Braided Hemp
            BraidedHemp = (Stem * 5);
            TBBraidedHemp.Text = BraidedHemp.ToString("F0");

            //CoarseBonePowder
            CoarsedBonePowder = (AnimalBone * 10);
            TBCoarsedBonePowder.Text = CoarsedBonePowder.ToString("F0");

            //Cokes
            Cokes = (Charcoal * 10) + (Coal * 3);
            TBCokes.Text = Cokes.ToString("F0");

            //Compound Braid
            CompoundBraid = (BraidedHemp * 5) + (Thread * 5);
            TBCompoundBraid.Text = CompoundBraid.ToString("F0");

            //High Grade Suede
            HighGradeSuede = (CoarsedBonePowder * 1) + (Suede * 3);
            TBHighGradeSuede.Text = HighGradeSuede.ToString("F0");

            //Leather
            Leather = (AnimalSkin * 6);
            TBLeather.Text = Leather.ToString("F0");

            //Metal Hardener
            MetalHardener = (IronOre * 10) + (Stem * 10) + (Varnish * 10);
            TBMetalHardener.Text = MetalHardener.ToString("F0");

            //Metallic Thread
            MetallicThread = (IronOre * 5) + (Thread * 10);
            TBMetallicThread.Text = MetallicThread.ToString("F0");

            //Durable Metal Plate
            DurableMetalPlate = (MetallicThread * 5) + (MithrilOre * 5);
            TBDurableMetalPlate.Text = DurableMetalPlate.ToString("F0");

            //Steel
            Steel = (IronOre * 5) + (Varnish * 5);
            TBSteel.Text = Steel.ToString("F0");

            //Cord
            Cord = ((Steel * 2) + (Thread * 25)) / 20;
            TBCord.Text = Cord.ToString("F0");

            //Metallic Fiber
            MetallicFiber = ((SilverNugget * 15) + (Cord * 20)) / 20;
            TBMetallicFiber.Text = MetallicFiber.ToString("F0");

            //Crafted Leather
            CraftedLeather = (Coal * 4) + (Cord * 4) + (Leather * 4);
            TBCraftedLeather.Text = CraftedLeather.ToString("F0");

            //Steel Mold
            SteelMold = (BraidedHemp * 5) + (Coal * 5) + (IronOre * 5);
            TBSteelMold.Text = SteelMold.ToString("F0");

            //Syntetic Cokes
            SyntheticCokes = (OriharukonOre * 1) + (Cokes * 3);
            TBSyntheticCokes.Text = SyntheticCokes.ToString("F0");

            //Oriharukon
            Oriharukon = (SyntheticCokes * 1) + (OriharukonOre * 4) + (SilverNugget * 12);
            TBOriharukon.Text = Oriharukon.ToString("F0");

            //Varnish Of Purity
            VarnishOfPurity = (StoneOfPurity * 1) + (CoarsedBonePowder * 3) + (Varnish * 3);
            TBVarnishOfPurity.Text = VarnishOfPurity.ToString("F0");

            //Mithril Alloy
            MithrilAlloy = (MithrilOre * 1) + (VarnishOfPurity * 1) + (Steel * 2);
            TBMithrilAlloy.Text = MithrilAlloy.ToString("F0");

            //Silver Mold
            SilverMold = (BraidedHemp * 5) + (Cokes * 5) + (SilverNugget * 10);
            TBSilverMold.Text = SilverMold.ToString("F0");

            //Blacksmith's Frame
            BlacksmithsFrame = (SilverMold * 1) + (VarnishOfPurity * 5) + (MithrilOre * 10);
            TBBlacksmithsFrame.Text = BlacksmithsFrame.ToString("F0");

            //Artisan's Frame
            ArtisansFrame = (SteelMold * 1) + (VarnishOfPurity * 5) + (AdamantiteNugget * 10);
            TBArtisansFrame.Text = ArtisansFrame.ToString("F0");

            //Craftsman Mold
            CraftsmanMold = (ArtisansFrame * 2) + (Enria * 5) + (MoldHardener * 20);
            TBCraftsmanMold.Text = CraftsmanMold.ToString("F0");

            //Leolin's Mold
            LeolinsMold = (DurableMetalPlate * 10) + (AdamantiteNugget * 15) + (Cord * 40);
            TBLeolinsMold.Text = LeolinsMold.ToString("F0");

            //Maestro Anvil Lock
            MaestroAnvilLock = (MoldGlue * 4) + (MoldLubricant * 4) + (SyntheticCokes * 4);
            TBMaestroAnvilLock.Text = MaestroAnvilLock.ToString("F0");

            //Arcsmith's Anvil
            ArcsmithsAnvil = (MaestroAnvilLock * 3) + (Thons * 10) + (MoldLubricant * 20);
            TBArcsmithsAnvil.Text = ArcsmithsAnvil.ToString("F0");

            //Maestro Holder
            MaestroHolder = (MoldHardener * 10) + (MoldLubricant * 10) + (VarnishOfPurity * 10);
            TBMaestroHolder.Text = MaestroHolder.ToString("F0");

            //Maestro Mold
            MaestroMold = (BlacksmithsFrame * 1) + (Asofe * 5) + (MoldGlue * 10);
            TBMaestroMold.Text = MaestroMold.ToString("F0");

            //Warsmith's Holder
            WarsmithsHolder = (ArtisansFrame * 1) + (Enria * 5) + (MoldHardener * 10);
            TBWarsmithsHolder.Text = WarsmithsHolder.ToString("F0");

            //TBWarsmithsMold
            WarsmithsMold = (MaestroHolder * 2) + (MoldGlue * 10) + (Thread * 20);
            TBWarsmithsMold.Text = WarsmithsMold.ToString("F0");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void ButCryCalc_Click(object sender, EventArgs e)
        {
            //Перевод Стринг в Инт для Револа
            double SwordOfRevolution;
            double.TryParse(TBSwordOfRevolution.Text, out SwordOfRevolution);

                //Считаем цену крисов
            double Cry_d, Cry_c, Cry_b, StoneOfPurity;
            double.TryParse(TBStoneOfPurity.Text, out StoneOfPurity);

            Cry_d = SwordOfRevolution / 2545;
            TBCry_d.Text = Cry_d.ToString("F0");

            Cry_c = ((SwordOfRevolution * 2) + (Cry_d * 178)) / 1148;
            TBCry_c.Text = Cry_c.ToString("F0");

            Cry_b = ((((Cry_d * 5375) + (Cry_c * 1075)) * 2) + (StoneOfPurity * 45)) / 1157;
            TBCry_b.Text = Cry_b.ToString("F0");
        }

        private void ButCryCalcAA_Click(object sender, EventArgs e)
        {
            double AncientAdena, Cry_a, Cry_s, Gem_a, Gem_s;
            double.TryParse(TBAncientAdena.Text, out AncientAdena);

            Cry_a = AncientAdena * 15000;
            TBCry_a.Text = Cry_a.ToString("F0");

            Cry_s = AncientAdena * 25000;
            TBCry_s.Text = Cry_s.ToString("F0");

            Gem_a = AncientAdena * 30000;
            TBGem_a.Text = Gem_a.ToString("F0");

            Gem_s = AncientAdena * 100000;
            TBGem_s.Text = Gem_s.ToString("F0");
        }

        private void ButItemCost_Click(object sender, EventArgs e)
        {

            double BraidedHemp, CoarsedBonePowder, Cokes, CompoundBraid, HighGradeSuede, Leather, MetalHardener, MetallicThread, DurableMetalPlate, Steel, Cord, MetallicFiber,
            CraftedLeather, SteelMold, SyntheticCokes, Oriharukon, VarnishOfPurity, MithrilAlloy, SilverMold, BlacksmithsFrame, ArtisansFrame, CraftsmanMold,
            ArcsmithsAnvil, MaestroAnvilLock, LeolinsMold, MaestroHolder, MaestroMold, WarsmithsHolder, WarsmithsMold;

            double AdamantiteNugget, AnimalBone, AnimalSkin, Asofe, Charcoal, Coal,
            Enria, IronOre, MithrilOre, MoldGlue, MoldHardener, MoldLubricant,
            OriharukonOre, SilverNugget, Stem, StoneOfPurity, Suede, Thons, Thread,
            Varnish, Cry_d, Cry_c, Cry_b, Cry_a, Cry_s, SoulOre, SpiritOre, Gem_d, Gem_c, Gem_b, Gem_a, Gem_s;
            double SSD, SpSD, BSpSD, SSC, SpSC, BSpSC, SSB, SpSB, BSpSB, SSA, SpSA, BSpSA, SSS, SpSS, BSpSS;
            double WeaponHeavensDivider, WeaponForgottenBlade;

            //Парсим крисы и руду
            double.TryParse(TBCry_d.Text, out Cry_d);
            double.TryParse(TBCry_c.Text, out Cry_c);
            double.TryParse(TBCry_b.Text, out Cry_b);
            double.TryParse(TBCry_a.Text, out Cry_a);
            double.TryParse(TBCry_s.Text, out Cry_s);
            double.TryParse(TBSoulOre.Text, out SoulOre);
            double.TryParse(TBSpiritOre.Text, out SpiritOre);
            double.TryParse(TBGem_d.Text, out Gem_d);
            double.TryParse(TBGem_c.Text, out Gem_c);
            double.TryParse(TBGem_b.Text, out Gem_b);
            double.TryParse(TBGem_a.Text, out Gem_a);
            double.TryParse(TBGem_s.Text, out Gem_s);

            //Парсим обычные ресурсы
            double.TryParse(TBAdamantiteNugget.Text, out AdamantiteNugget);
            double.TryParse(TBAnimalBone.Text, out AnimalBone);
            double.TryParse(TBAnimalSkin.Text, out AnimalSkin);
            double.TryParse(TBAsofe.Text, out Asofe);
            double.TryParse(TBCharcoal.Text, out Charcoal);
            double.TryParse(TBCoal.Text, out Coal);
            double.TryParse(TBEnria.Text, out Enria);
            double.TryParse(TBIronOre.Text, out IronOre);
            double.TryParse(TBMithrilOre.Text, out MithrilOre);
            double.TryParse(TBMoldGlue.Text, out MoldGlue);
            double.TryParse(TBMoldHardener.Text, out MoldHardener);
            double.TryParse(TBMoldLubricant.Text, out MoldLubricant);
            double.TryParse(TBOriharukonOre.Text, out OriharukonOre);
            double.TryParse(TBSilverNugget.Text, out SilverNugget);
            double.TryParse(TBStem.Text, out Stem);
            double.TryParse(TBStoneOfPurity.Text, out StoneOfPurity);
            double.TryParse(TBSuede.Text, out Suede);
            double.TryParse(TBThons.Text, out Thons);
            double.TryParse(TBThread.Text, out Thread);
            double.TryParse(TBVarnish.Text, out Varnish);

            //Парсим крафтовые ресурсы
            double.TryParse(TBBraidedHemp.Text, out BraidedHemp);
            double.TryParse(TBCoarsedBonePowder.Text, out CoarsedBonePowder);
            double.TryParse(TBCokes.Text, out Cokes);
            double.TryParse(TBCompoundBraid.Text, out CompoundBraid);
            double.TryParse(TBHighGradeSuede.Text, out HighGradeSuede);
            double.TryParse(TBLeather.Text, out Leather);
            double.TryParse(TBMetalHardener.Text, out MetalHardener);
            double.TryParse(TBMetallicThread.Text, out MetallicThread);
            double.TryParse(TBDurableMetalPlate.Text, out DurableMetalPlate);
            double.TryParse(TBSteel.Text, out Steel);
            double.TryParse(TBCord.Text, out Cord);
            double.TryParse(TBMetallicFiber.Text, out MetallicFiber);
            double.TryParse(TBCraftedLeather.Text, out CraftedLeather);
            double.TryParse(TBSteelMold.Text, out SteelMold);
            double.TryParse(TBSyntheticCokes.Text, out SyntheticCokes);
            double.TryParse(TBOriharukon.Text, out Oriharukon);
            double.TryParse(TBVarnishOfPurity.Text, out VarnishOfPurity);
            double.TryParse(TBMithrilAlloy.Text, out MithrilAlloy);
            double.TryParse(TBSilverMold.Text, out SilverMold);
            double.TryParse(TBBlacksmithsFrame.Text, out BlacksmithsFrame);
            double.TryParse(TBArtisansFrame.Text, out ArtisansFrame);
            double.TryParse(TBCraftsmanMold.Text, out CraftsmanMold);
            double.TryParse(TBArcsmithsAnvil.Text, out ArcsmithsAnvil);
            double.TryParse(TBMaestroAnvilLock.Text, out MaestroAnvilLock);
            double.TryParse(TBLeolinsMold.Text, out LeolinsMold);
            double.TryParse(TBMaestroHolder.Text, out MaestroHolder);
            double.TryParse(TBMaestroMold.Text, out MaestroMold);
            double.TryParse(TBWarsmithsHolder.Text, out WarsmithsHolder);
            double.TryParse(TBWarsmithsMold.Text, out WarsmithsMold);


            // D
            SSD = (Cry_d + (SoulOre * 3)) / 156;
            LabSSD.Text = SSD.ToString("F2");

            SpSD = (Cry_d + (SpiritOre * 3)) / 100;
            LabSpSD.Text = SpSD.ToString("F2");

            BSpSD = ((Cry_d * 2) + (SpiritOre * 8)) / 100;
            LabBSpSD.Text = BSpSD.ToString("F2");

            // C
            SSC = (Cry_c + (SoulOre * 15)) / 476;
            LabSSC.Text = SSC.ToString("F2");

            SpSC = (Cry_c + (SpiritOre * 10)) / 200;
            LabSpSC.Text = SpSC.ToString("F2");

            BSpSC = ((Cry_c * 2) + (SpiritOre * 30)) / 200;
            LabBSpSC.Text = BSpSC.ToString("F2");

            // B
            SSB = (Cry_b + (SoulOre * 54)) / 450;
            LabSSB.Text = SSB.ToString("F2");

            SpSB = (Cry_b + (SpiritOre * 15)) / 150;
            LabSpSB.Text = SpSB.ToString("F2");

            BSpSB = ((Cry_b * 2) + (SpiritOre * 16)) / 100;
            LabBSpSB.Text = BSpSB.ToString("F2");

            // A
            SSA = (Cry_a + (SoulOre * 36)) / 300;
            LabSSA.Text = SSA.ToString("F2");

            SpSA = (Cry_a + (SpiritOre * 22)) / 200;
            LabSpSA.Text = SpSA.ToString("F2");

            BSpSA = ((Cry_a * 2) + (SpiritOre * 70)) / 200;
            LabBSpSA.Text = BSpSA.ToString("F2");

            // S
            SSS = (Cry_s + (SoulOre * 40)) / 350;
            LabSSS.Text = SSS.ToString("F2");

            SpSS = (Cry_s + (SpiritOre * 15)) / 200;
            LabSpSS.Text = SpSS.ToString("F2");

            BSpSS = ((Cry_s * 2) + (SpiritOre * 50)) / 200;
            LabBSpSS.Text = BSpSS.ToString("F2");

            // Weapons
            // S-Grade
            WeaponHeavensDivider = (Cry_s * 212) + (SyntheticCokes * 146) + (MithrilAlloy * 292) + (Gem_s * 43) + (Enria * 146) + (DurableMetalPlate * 146) + (WarsmithsHolder * 4);
            LabCostHeavensDivider.Text = WeaponHeavensDivider.ToString("F0");

            WeaponForgottenBlade = (Cry_s * 211) + (SyntheticCokes * 264) + (MithrilAlloy * 264) + (Gem_s * 43) + (Enria * 132) + (DurableMetalPlate * 132) + (WarsmithsHolder * 4);
            LabCostForgottenBlade.Text = WeaponForgottenBlade.ToString("F0");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vk.com/id179902989");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://surfory.com/59293?welcome=UZE79D");
        }

        //Сохранение при нажатии кнопки "сохранить"
        //Переменные описаны в классе SaveSettings
        private void ButSave_Click(object sender, EventArgs e)
        {
            SaveSettings SavSet = new SaveSettings();

            //Парсим строки из ТБ в double для сохранения

            //Простые ресурсы
            double.TryParse(TBAdamantiteNugget.Text, out SavSet.SaveAdamantiteNugget);
            double.TryParse(TBAnimalBone.Text, out SavSet.SaveAnimalBone);
            double.TryParse(TBAnimalSkin.Text, out SavSet.SaveAnimalSkin);
            double.TryParse(TBAsofe.Text, out SavSet.SaveAsofe);
            double.TryParse(TBCharcoal.Text, out SavSet.SaveCharcoal);
            double.TryParse(TBCoal.Text, out SavSet.SaveCoal);
            double.TryParse(TBEnria.Text, out SavSet.SaveEnria);
            double.TryParse(TBIronOre.Text, out SavSet.SaveIronOre);
            double.TryParse(TBMithrilOre.Text, out SavSet.SaveMithrilOre);
            double.TryParse(TBMoldGlue.Text, out SavSet.SaveMoldGlue);
            double.TryParse(TBMoldHardener.Text, out SavSet.SaveMoldHardener);
            double.TryParse(TBMoldLubricant.Text, out SavSet.SaveMoldLubricant);
            double.TryParse(TBOriharukonOre.Text, out SavSet.SaveOriharukonOre);
            double.TryParse(TBSilverNugget.Text, out SavSet.SaveSilverNugget);
            double.TryParse(TBStem.Text, out SavSet.SaveStem);
            double.TryParse(TBStoneOfPurity.Text, out SavSet.SaveStoneOfPurity);
            double.TryParse(TBSuede.Text, out SavSet.SaveSuede);
            double.TryParse(TBThons.Text, out SavSet.SaveThons);
            double.TryParse(TBThread.Text, out SavSet.SaveThread);
            double.TryParse(TBVarnish.Text, out SavSet.SaveVarnish);
            double.TryParse(TBCry_d.Text, out SavSet.SaveCry_d);
            double.TryParse(TBCry_c.Text, out SavSet.SaveCry_c);
            double.TryParse(TBCry_b.Text, out SavSet.SaveCry_b);
            double.TryParse(TBCry_a.Text, out SavSet.SaveCry_a);
            double.TryParse(TBCry_s.Text, out SavSet.SaveCry_s);
            double.TryParse(TBGem_d.Text, out SavSet.SaveGem_d);
            double.TryParse(TBGem_c.Text, out SavSet.SaveGem_c);
            double.TryParse(TBGem_b.Text, out SavSet.SaveGem_b);
            double.TryParse(TBGem_a.Text, out SavSet.SaveGem_a);
            double.TryParse(TBGem_s.Text, out SavSet.SaveGem_s);

            //Крафтовые ресурсы
            double.TryParse(TBBraidedHemp.Text, out SavSet.SaveBraidedHemp);
            double.TryParse(TBCoarsedBonePowder.Text, out SavSet.SaveCoarsedBonePowder);
            double.TryParse(TBCokes.Text, out SavSet.SaveCokes);
            double.TryParse(TBCompoundBraid.Text, out SavSet.SaveCompoundBraid);
            double.TryParse(TBHighGradeSuede.Text, out SavSet.SaveHighGradeSuede);
            double.TryParse(TBLeather.Text, out SavSet.SaveLeather);
            double.TryParse(TBMetalHardener.Text, out SavSet.SaveMetalHardener);
            double.TryParse(TBMetallicThread.Text, out SavSet.SaveMetallicThread);
            double.TryParse(TBDurableMetalPlate.Text, out SavSet.SaveDurableMetalPlate);
            double.TryParse(TBSteel.Text, out SavSet.SaveSteel);
            double.TryParse(TBCord.Text, out SavSet.SaveCord);
            double.TryParse(TBMetallicFiber.Text, out SavSet.SaveMetallicFiber);
            double.TryParse(TBCraftedLeather.Text, out SavSet.SaveCraftedLeather);
            double.TryParse(TBSteelMold.Text, out SavSet.SaveSteelMold);
            double.TryParse(TBSyntheticCokes.Text, out SavSet.SaveSynteticCokes);
            double.TryParse(TBOriharukon.Text, out SavSet.SaveOriharukon);
            double.TryParse(TBVarnishOfPurity.Text, out SavSet.SaveVarnishOfPurity);
            double.TryParse(TBMithrilAlloy.Text, out SavSet.SaveMithrilAlloy);
            double.TryParse(TBSilverMold.Text, out SavSet.SaveSilverMold);
            double.TryParse(TBBlacksmithsFrame.Text, out SavSet.SaveBlacksmithsFrame);
            double.TryParse(TBArtisansFrame.Text, out SavSet.SaveArtisansFrame);
            double.TryParse(TBCraftsmanMold.Text, out SavSet.SaveCraftsmanMold);
            double.TryParse(TBArcsmithsAnvil.Text, out SavSet.SaveArcsmithsAnvil);
            double.TryParse(TBMaestroAnvilLock.Text, out SavSet.SaveMaestroAnvilLock);
            double.TryParse(TBLeolinsMold.Text, out SavSet.SaveLeolinsMold);
            double.TryParse(TBMaestroHolder.Text, out SavSet.SaveMaestroHolder);
            double.TryParse(TBMaestroMold.Text, out SavSet.SaveMaestroMold);
            double.TryParse(TBWarsmithsHolder.Text, out SavSet.SaveWarsmithsHolder);
            double.TryParse(TBWarsmithsMold.Text, out SavSet.SaveWarsmithsMold);

            //Револ
            double.TryParse(TBSwordOfRevolution.Text, out SavSet.SaveSwordOfRevolution);

            //АА
            double.TryParse(TBAncientAdena.Text, out SavSet.SaveAncientAdena);

            //Соул и спирит оре
            double.TryParse(TBSoulOre.Text, out SavSet.SaveSoulOre);
            double.TryParse(TBSpiritOre.Text, out SavSet.SaveSpiritOre);

            //---------------------------------------------------------------------//

            //выкладываем весь объект SavSet в xml файл
            using (Stream writer = new FileStream("data.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SaveSettings));
                serializer.Serialize(writer, SavSet);

            }

            //Говорим, что все ОК
            MessageBox.Show("Цены сохранены", "Все хорошо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Загрузка всех цен при нажатии кнопки "Загрузить"
        private void ButLoad_Click(object sender, EventArgs e)
        {
            int debug = 0; 

            try
            {
                // Читаем и загружаем данные из файла data.xml 
                using (Stream stream = new FileStream("data.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(SaveSettings));
                    SaveSettings SavSet = (SaveSettings)serializer.Deserialize(stream);

                    //Загружаем прочитанные данные в ТБшки

                    //Простые ресурсы
                    TBAdamantiteNugget.Text = SavSet.SaveAdamantiteNugget.ToString("F0");
                    TBAnimalBone.Text = SavSet.SaveAnimalBone.ToString("F0");
                    TBAnimalSkin.Text = SavSet.SaveAnimalSkin.ToString("F0");
                    TBAsofe.Text = SavSet.SaveAsofe.ToString("F0");
                    TBCharcoal.Text = SavSet.SaveCharcoal.ToString("F0");
                    TBCoal.Text = SavSet.SaveCoal.ToString("F0");
                    TBEnria.Text = SavSet.SaveEnria.ToString("F0");
                    TBIronOre.Text = SavSet.SaveIronOre.ToString("F0");
                    TBMithrilOre.Text = SavSet.SaveMithrilOre.ToString("F0");
                    TBMoldGlue.Text = SavSet.SaveMoldGlue.ToString("F0");
                    TBMoldHardener.Text = SavSet.SaveMoldHardener.ToString("F0");
                    TBMoldLubricant.Text = SavSet.SaveMoldLubricant.ToString("F0");
                    TBOriharukonOre.Text = SavSet.SaveOriharukonOre.ToString("F0");
                    TBSilverNugget.Text = SavSet.SaveSilverNugget.ToString("F0");
                    TBStem.Text = SavSet.SaveStem.ToString("F0");
                    TBStoneOfPurity.Text = SavSet.SaveStoneOfPurity.ToString("F0");
                    TBSuede.Text = SavSet.SaveSuede.ToString("F0");
                    TBThons.Text = SavSet.SaveThons.ToString("F0");
                    TBThread.Text = SavSet.SaveThread.ToString("F0");
                    TBVarnish.Text = SavSet.SaveVarnish.ToString("F0");
                    TBCry_d.Text = SavSet.SaveCry_d.ToString("F0");
                    TBCry_c.Text = SavSet.SaveCry_c.ToString("F0");
                    TBCry_b.Text = SavSet.SaveCry_b.ToString("F0");
                    TBCry_a.Text = SavSet.SaveCry_a.ToString("F0");
                    TBCry_s.Text = SavSet.SaveCry_s.ToString("F0");
                    TBGem_d.Text = SavSet.SaveGem_d.ToString("F0");
                    TBGem_c.Text = SavSet.SaveGem_c.ToString("F0");
                    TBGem_b.Text = SavSet.SaveGem_b.ToString("F0");
                    TBGem_a.Text = SavSet.SaveGem_a.ToString("F0");
                    TBGem_s.Text = SavSet.SaveGem_s.ToString("F0");

                    //Крафтовые ресурсы
                    TBBraidedHemp.Text = SavSet.SaveBraidedHemp.ToString("F0");
                    TBCoarsedBonePowder.Text = SavSet.SaveCoarsedBonePowder.ToString("F0");
                    TBCokes.Text = SavSet.SaveCokes.ToString("F0");
                    TBCompoundBraid.Text = SavSet.SaveCompoundBraid.ToString("F0");
                    TBHighGradeSuede.Text = SavSet.SaveHighGradeSuede.ToString("F0");
                    TBLeather.Text = SavSet.SaveLeather.ToString("F0");
                    TBMetalHardener.Text = SavSet.SaveMetalHardener.ToString("F0");
                    TBMetallicThread.Text = SavSet.SaveMetallicThread.ToString("F0");
                    TBDurableMetalPlate.Text = SavSet.SaveDurableMetalPlate.ToString("F0");
                    TBSteel.Text = SavSet.SaveSteel.ToString("F0");
                    TBCord.Text = SavSet.SaveCord.ToString("F0");
                    TBMetallicFiber.Text = SavSet.SaveMetallicFiber.ToString("F0");
                    TBCraftedLeather.Text = SavSet.SaveCraftedLeather.ToString("F0");
                    TBSteelMold.Text = SavSet.SaveSteelMold.ToString("F0");
                    TBSyntheticCokes.Text = SavSet.SaveSynteticCokes.ToString("F0");
                    TBOriharukon.Text = SavSet.SaveOriharukon.ToString("F0");
                    TBVarnishOfPurity.Text = SavSet.SaveVarnishOfPurity.ToString("F0");
                    TBMithrilAlloy.Text = SavSet.SaveMithrilAlloy.ToString("F0");
                    TBSilverMold.Text = SavSet.SaveSilverMold.ToString("F0");
                    TBBlacksmithsFrame.Text = SavSet.SaveBlacksmithsFrame.ToString("F0");
                    TBArtisansFrame.Text = SavSet.SaveArtisansFrame.ToString("F0");
                    TBCraftsmanMold.Text = SavSet.SaveCraftsmanMold.ToString("F0");
                    TBArcsmithsAnvil.Text = SavSet.SaveArcsmithsAnvil.ToString("F0");
                    TBMaestroAnvilLock.Text = SavSet.SaveMaestroAnvilLock.ToString("F0");
                    TBLeolinsMold.Text = SavSet.SaveLeolinsMold.ToString("F0");
                    TBMaestroHolder.Text = SavSet.SaveMaestroHolder.ToString("F0");
                    TBMaestroMold.Text = SavSet.SaveMaestroMold.ToString("F0");
                    TBWarsmithsHolder.Text = SavSet.SaveWarsmithsHolder.ToString("F0");
                    TBWarsmithsMold.Text = SavSet.SaveWarsmithsMold.ToString("F0");

                    //Револ
                    TBSwordOfRevolution.Text = SavSet.SaveSwordOfRevolution.ToString("F0");

                    //АА
                    TBAncientAdena.Text = SavSet.SaveAncientAdena.ToString("F0");

                    //Соул и спирит оре
                    TBSoulOre.Text = SavSet.SaveSoulOre.ToString("F0");
                    TBSpiritOre.Text = SavSet.SaveSpiritOre.ToString("F0");
                }
            }
            catch (FileNotFoundException)
            {
                //Косяк - нет xml файла
                MessageBox.Show("Нет сохраненной информации", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
                debug = 1;
            }
            //Если косяков не было - пишем, что все ОК
            if (debug == 0)
                {
                MessageBox.Show("Цены загружены", "Все хорошо", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }

        private void ButPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция не реализована. Пока что.", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
