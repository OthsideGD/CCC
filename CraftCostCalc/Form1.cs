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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ButResCraftCalc_Click(object sender, EventArgs e)
        {
            //--------------------------------------
            //Вывод подсказки
            LabHelp.Text = "В крафтовых ресурсах верхняя цена - СЕБЕСТОИМОСТЬ, нижняя - РЫНОЧНАЯ цена на Вашем сервер. Рыночная цена используется только для сравнения и запоминания.";
            //--------------------------------------
            //Подсчет цены крафтовые ресурсы

            //Перевод Стринг в Инт для базовых ресурсов
            double AdamantiteNugget, AnimalBone, AnimalSkin, Asofe, Charcoal, Coal,
            Enria, IronOre, MithrilOre, MoldGlue, MoldHardener, MoldLubricant,
            OriharukonOre, SilverNugget, Stem, StoneOfPurity, Suede, Thons, Thread,
            Varnish, Cry_d, Cry_c, Cry_b, Cry_a, Cry_s, Gem_d, Gem_c, Gem_b, Gem_a, Gem_s;

            double.TryParse(TBCostAdamantiteNugget.Text, out AdamantiteNugget);
            double.TryParse(TBCostAnimalBone.Text, out AnimalBone);
            double.TryParse(TBCostAnimalSkin.Text, out AnimalSkin);
            double.TryParse(TBCostAsofe.Text, out Asofe);
            double.TryParse(TBCostCharcoal.Text, out Charcoal);
            double.TryParse(TBCostCoal.Text, out Coal);
            double.TryParse(TBCostEnria.Text, out Enria);
            double.TryParse(TBCostIronOre.Text, out IronOre);
            double.TryParse(TBCostMithrilOre.Text, out MithrilOre);
            double.TryParse(TBCostMoldGlue.Text, out MoldGlue);
            double.TryParse(TBCostMoldHardener.Text, out MoldHardener);
            double.TryParse(TBCostMoldLubricant.Text, out MoldLubricant);
            double.TryParse(TBCostOriharukonOre.Text, out OriharukonOre);
            double.TryParse(TBCostSilverNugget.Text, out SilverNugget);
            double.TryParse(TBCostStem.Text, out Stem);
            double.TryParse(TBCostStoneOfPurity.Text, out StoneOfPurity);
            double.TryParse(TBCostSuede.Text, out Suede);
            double.TryParse(TBCostThons.Text, out Thons);
            double.TryParse(TBCostThread.Text, out Thread);
            double.TryParse(TBCostVarnish.Text, out Varnish);
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
            double BraidedHemp, CoarseBonePowder, Cokes, CompoundBraid, HighGradeSuede, Leather, MetalHardener, MetallicThread, DurableMetalPlate, Steel, Cord, MetallicFiber,
            CraftedLeather, SteelMold, SyntheticCokes, Oriharukon, VarnishOfPurity,MithrilAlloy, SilverMold, BlacksmithsFrame, ArtisansFrame, CraftsmanMold,
            ArcsmithsAnvil, MaestroAnvilLock, LeolinsMold, MaestroHolder, MaestroMold, WarsmithsHolder, WarsmithsMold;
             

            //Braided Hemp
            BraidedHemp = (Stem * 5);
            LabCraftCostBraidedHemp.Text = BraidedHemp.ToString("F0");

            //CoarseBonePowder
            CoarseBonePowder = (AnimalBone * 10);
            LabCraftCostCoarseBonePowder.Text = CoarseBonePowder.ToString("F0");

            //Cokes
            Cokes = (Charcoal * 10) + (Coal * 3);
            LabCraftCostCokes.Text = Cokes.ToString("F0");

            //Compound Braid
            CompoundBraid = (BraidedHemp * 5) + (Thread * 5);
            LabCraftCostCompoundBraid.Text = CompoundBraid.ToString("F0");

            //High Grade Suede
            HighGradeSuede = (CoarseBonePowder * 1) + (Suede * 3);
            LabCraftCostHighGradeSuede.Text = HighGradeSuede.ToString("F0");

            //Leather
            Leather = (AnimalSkin * 6);
            LabCraftCostLeather.Text = Leather.ToString("F0");

            //Metal Hardener
            MetalHardener = (IronOre * 10) + (Stem * 10) + (Varnish * 10);
            LabCraftCostMetalHardener.Text = MetalHardener.ToString("F0");

            //Metallic Thread
            MetallicThread = (IronOre * 5) + (Thread * 10);
            LabCraftCostMetallicThread.Text = MetallicThread.ToString("F0");

            //Durable Metal Plate
            DurableMetalPlate = (MetallicThread * 5) + (MithrilOre * 5);
            LabCraftCostDurableMetalPlate.Text = DurableMetalPlate.ToString("F0");

            //Steel
            Steel = (IronOre * 5) + (Varnish * 5);
            LabCraftCostSteel.Text = Steel.ToString("F0");

            //Cord
            Cord = ((Steel * 2) + (Thread * 25)) / 20;
            LabCraftCostCord.Text = Cord.ToString("F0");

            //Metallic Fiber
            MetallicFiber = ((SilverNugget * 15) + (Cord * 20)) / 20;
            LabCraftCostMetallicFiber.Text = MetallicFiber.ToString("F0");

            //Crafted Leather
            CraftedLeather = (Coal * 4) + (Cord * 4) + (Leather * 4);
            LabCraftCostCraftedLeather.Text = CraftedLeather.ToString("F0");

            //Steel Mold
            SteelMold = (BraidedHemp * 5) + (Coal * 5) + (IronOre * 5);
            LabCraftCostSteelMold.Text = SteelMold.ToString("F0");

            //Syntetic Cokes
            SyntheticCokes = (OriharukonOre * 1) + (Cokes * 3);
            LabCraftCostSyntheticCokes.Text = SyntheticCokes.ToString("F0");

            //Oriharukon
            Oriharukon = (SyntheticCokes * 1) + (OriharukonOre * 4) + (SilverNugget * 12);
            LabCraftCostOriharukon.Text = Oriharukon.ToString("F0");

            //Varnish Of Purity
            VarnishOfPurity = (StoneOfPurity * 1) + (CoarseBonePowder * 3) + (Varnish * 3);
            LabCraftCostVarnishOfPurity.Text = VarnishOfPurity.ToString("F0");

            //Mithril Alloy
            MithrilAlloy = (MithrilOre * 1) + (VarnishOfPurity * 1) + (Steel * 2);
            LabCraftCostMithrilAlloy.Text = MithrilAlloy.ToString("F0");

            //Silver Mold
            SilverMold = (BraidedHemp * 5) + (Cokes * 5) + (SilverNugget * 10);
            LabCraftCostSilverMold.Text = SilverMold.ToString("F0");

            //Blacksmith's Frame
            BlacksmithsFrame = (SilverMold * 1) + (VarnishOfPurity * 5) + (MithrilOre * 10);
            LabCraftCostBlacksmithsFrame.Text = BlacksmithsFrame.ToString("F0");

            //Artisan's Frame
            ArtisansFrame = (SteelMold * 1) + (VarnishOfPurity * 5) + (AdamantiteNugget * 10);
            LabCraftCostArtisansFrame.Text = ArtisansFrame.ToString("F0");

            //Craftsman Mold
            CraftsmanMold = (ArtisansFrame * 2) + (Enria * 5) + (MoldHardener * 20);
            LabCraftCostCraftsmanMold.Text = CraftsmanMold.ToString("F0");

            //Leolin's Mold
            LeolinsMold = (DurableMetalPlate * 10) + (AdamantiteNugget * 15) + (Cord * 40);
            LabCraftCostLeolinsMold.Text = LeolinsMold.ToString("F0");

            //Maestro Anvil Lock
            MaestroAnvilLock = (MoldGlue * 4) + (MoldLubricant * 4) + (SyntheticCokes * 4);
            LabCraftCostMaestroAnvilLock.Text = MaestroAnvilLock.ToString("F0");

            //Arcsmith's Anvil
            ArcsmithsAnvil = (MaestroAnvilLock * 3) + (Thons * 10) + (MoldLubricant * 20);
            LabCraftCostArcsmithsAnvil.Text = ArcsmithsAnvil.ToString("F0");

            //Maestro Holder
            MaestroHolder = (MoldHardener * 10) + (MoldLubricant * 10) + (VarnishOfPurity * 10);
            LabCraftCostMaestroHolder.Text = MaestroHolder.ToString("F0");

            //Maestro Mold
            MaestroMold = (BlacksmithsFrame * 1) + (Asofe * 5) + (MoldGlue * 10);
            LabCraftCostMaestroMold.Text = MaestroMold.ToString("F0");

            //Warsmith's Holder
            WarsmithsHolder = (ArtisansFrame * 1) + (Enria * 5) + (MoldHardener * 10);
            LabCraftCostWarsmithsHolder.Text = WarsmithsHolder.ToString("F0");

            //TBWarsmithsMold
            WarsmithsMold = (MaestroHolder * 2) + (MoldGlue * 10) + (Thread * 20);
            LabCraftCostWarsmithsMold.Text = WarsmithsMold.ToString("F0");
        }

        private void ButCryCalc_Click(object sender, EventArgs e)
        {
            //Перевод Стринг в Инт для Револа
            double SwordOfRevolution;
            double.TryParse(TBSwordOfRevolutionToCry.Text, out SwordOfRevolution);

                //Считаем цену крисов
            double Cry_d, Cry_c, Cry_b, StoneOfPurity;
            double.TryParse(TBCostStoneOfPurity.Text, out StoneOfPurity);

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
            double.TryParse(TBAncientAdenaToCry.Text, out AncientAdena);

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

            double WeaponHeavensDivider, WeaponForgottenBlade, WeaponBasaltBattlehammer, WeaponDragonHunterAxe, WeaponArcanaMace, WeaponImperialStaff;

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
            double.TryParse(TBCostAdamantiteNugget.Text, out AdamantiteNugget);
            double.TryParse(TBCostAnimalBone.Text, out AnimalBone);
            double.TryParse(TBCostAnimalSkin.Text, out AnimalSkin);
            double.TryParse(TBCostAsofe.Text, out Asofe);
            double.TryParse(TBCostCharcoal.Text, out Charcoal);
            double.TryParse(TBCostCoal.Text, out Coal);
            double.TryParse(TBCostEnria.Text, out Enria);
            double.TryParse(TBCostIronOre.Text, out IronOre);
            double.TryParse(TBCostMithrilOre.Text, out MithrilOre);
            double.TryParse(TBCostMoldGlue.Text, out MoldGlue);
            double.TryParse(TBCostMoldHardener.Text, out MoldHardener);
            double.TryParse(TBCostMoldLubricant.Text, out MoldLubricant);
            double.TryParse(TBCostOriharukonOre.Text, out OriharukonOre);
            double.TryParse(TBCostSilverNugget.Text, out SilverNugget);
            double.TryParse(TBCostStem.Text, out Stem);
            double.TryParse(TBCostStoneOfPurity.Text, out StoneOfPurity);
            double.TryParse(TBCostSuede.Text, out Suede);
            double.TryParse(TBCostThons.Text, out Thons);
            double.TryParse(TBCostThread.Text, out Thread);
            double.TryParse(TBCostVarnish.Text, out Varnish);

            //Парсим крафтовые ресурсы
            double.TryParse(TBCostBraidedHemp.Text, out BraidedHemp);
            double.TryParse(TBCostCoarseBonePowder.Text, out CoarsedBonePowder);
            double.TryParse(TBCostCokes.Text, out Cokes);
            double.TryParse(TBCostCompoundBraid.Text, out CompoundBraid);
            double.TryParse(TBCostHighGradeSuede.Text, out HighGradeSuede);
            double.TryParse(TBCostLeather.Text, out Leather);
            double.TryParse(TBCostMetalHardener.Text, out MetalHardener);
            double.TryParse(TBCostMetallicThread.Text, out MetallicThread);
            double.TryParse(TBCostDurableMetalPlate.Text, out DurableMetalPlate);
            double.TryParse(TBCostSteel.Text, out Steel);
            double.TryParse(TBCostCord.Text, out Cord);
            double.TryParse(TBCostMetallicFiber.Text, out MetallicFiber);
            double.TryParse(TBCostCraftedLeather.Text, out CraftedLeather);
            double.TryParse(TBCostSteelMold.Text, out SteelMold);
            double.TryParse(TBCostSyntheticCokes.Text, out SyntheticCokes);
            double.TryParse(TBCostOriharukon.Text, out Oriharukon);
            double.TryParse(TBCostVarnishOfPurity.Text, out VarnishOfPurity);
            double.TryParse(TBCostMithrilAlloy.Text, out MithrilAlloy);
            double.TryParse(TBCostSilverMold.Text, out SilverMold);
            double.TryParse(TBCostBlacksmithsFrame.Text, out BlacksmithsFrame);
            double.TryParse(TBCostArtisansFrame.Text, out ArtisansFrame);
            double.TryParse(TBCostCraftsmanMold.Text, out CraftsmanMold);
            double.TryParse(TBCostArcsmithsAnvil.Text, out ArcsmithsAnvil);
            double.TryParse(TBCostMaestroAnvilLock.Text, out MaestroAnvilLock);
            double.TryParse(TBCostLeolinsMold.Text, out LeolinsMold);
            double.TryParse(TBCostMaestroHolder.Text, out MaestroHolder);
            double.TryParse(TBCostMaestroMold.Text, out MaestroMold);
            double.TryParse(TBCostWarsmithsHolder.Text, out WarsmithsHolder);
            double.TryParse(TBCostWarsmithsMold.Text, out WarsmithsMold);


            // D
            SSD = (Cry_d + (SoulOre * 3)) / 156;
            LabCraftCostSSD.Text = SSD.ToString("F2");

            SpSD = (Cry_d + (SpiritOre * 3)) / 100;
            LabCraftCostSpSD.Text = SpSD.ToString("F2");

            BSpSD = ((Cry_d * 2) + (SpiritOre * 8)) / 100;
            LabCraftCostBSpSD.Text = BSpSD.ToString("F2");

            // C
            SSC = (Cry_c + (SoulOre * 15)) / 476;
            LabCraftCostSSC.Text = SSC.ToString("F2");

            SpSC = (Cry_c + (SpiritOre * 10)) / 200;
            LabCraftCostSpSC.Text = SpSC.ToString("F2");

            BSpSC = ((Cry_c * 2) + (SpiritOre * 30)) / 200;
            LabCraftCostBSpSC.Text = BSpSC.ToString("F2");

            // B
            SSB = (Cry_b + (SoulOre * 54)) / 450;
            LabCraftCostSSB.Text = SSB.ToString("F2");

            SpSB = (Cry_b + (SpiritOre * 15)) / 150;
            LabCraftCostSpSB.Text = SpSB.ToString("F2");

            BSpSB = ((Cry_b * 2) + (SpiritOre * 16)) / 100;
            LabCraftCostBSpSB.Text = BSpSB.ToString("F2");

            // A
            SSA = (Cry_a + (SoulOre * 36)) / 300;
            LabCraftCostSSA.Text = SSA.ToString("F2");

            SpSA = (Cry_a + (SpiritOre * 22)) / 200;
            LabCraftCostSpSA.Text = SpSA.ToString("F2");

            BSpSA = ((Cry_a * 2) + (SpiritOre * 70)) / 200;
            LabCraftCostBSpSA.Text = BSpSA.ToString("F2");

            // S
            SSS = (Cry_s + (SoulOre * 40)) / 350;
            LabCraftCostSSS.Text = SSS.ToString("F2");

            SpSS = (Cry_s + (SpiritOre * 15)) / 200;
            LabCraftCostSpSS.Text = SpSS.ToString("F2");

            BSpSS = ((Cry_s * 2) + (SpiritOre * 50)) / 200;
            LabCraftCostBSpSS.Text = BSpSS.ToString("F2");

            // Weapons
            // S-Grade
            WeaponHeavensDivider = (Cry_s * 212) + (SyntheticCokes * 146) + (MithrilAlloy * 292) + (Gem_s * 43) + (Enria * 146) + (DurableMetalPlate * 146) + (WarsmithsHolder * 4);
            LabCostHeavensDivider.Text = WeaponHeavensDivider.ToString("F0");

            WeaponForgottenBlade = (Cry_s * 211) + (SyntheticCokes * 264) + (MithrilAlloy * 264) + (Gem_s * 43) + (Enria * 132) + (DurableMetalPlate * 132) + (WarsmithsHolder * 4);
            LabCostForgottenBlade.Text = WeaponForgottenBlade.ToString("F0");

            WeaponBasaltBattlehammer = (Cry_s * 211) + (SyntheticCokes * 154) + (MithrilAlloy * 154) + (Gem_s * 43) + (Enria * 77) + (DurableMetalPlate * 308) + (WarsmithsHolder * 4);
            LabCostBasaltBattlehammer.Text = WeaponBasaltBattlehammer.ToString("F0");

            WeaponDragonHunterAxe = (Cry_s * 214) + (SyntheticCokes * 124) + (MithrilAlloy * 248) + (Gem_s * 43) + (Enria * 62) + (DurableMetalPlate * 248) + (WarsmithsHolder * 4);
            LabCostDragonHunterAxe.Text = WeaponDragonHunterAxe.ToString("F0");

            WeaponArcanaMace = (Cry_s * 211) + (SyntheticCokes * 154) + (MithrilAlloy * 154) + (Gem_s * 43) + (Enria * 77) + (DurableMetalPlate * 308) + (WarsmithsHolder * 4);
            LabCostArcanaMace.Text = WeaponArcanaMace.ToString("F0");

            WeaponImperialStaff = (Cry_s * 210) + (CoarsedBonePowder * 242) + (CompoundBraid * 121) + (Oriharukon * 121) + (Gem_s * 43) + (Enria * 121) + (DurableMetalPlate * 242) + (WarsmithsHolder * 4);
            LabCostImperialStaff.Text = WeaponImperialStaff.ToString("F0");
        }

        private void LLabShodVK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vk.com/id179902989");
        }

        private void LLabShodSurfory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            double.TryParse(TBCostAdamantiteNugget.Text, out SavSet.SaveAdamantiteNugget);
            double.TryParse(TBCostAnimalBone.Text, out SavSet.SaveAnimalBone);
            double.TryParse(TBCostAnimalSkin.Text, out SavSet.SaveAnimalSkin);
            double.TryParse(TBCostAsofe.Text, out SavSet.SaveAsofe);
            double.TryParse(TBCostCharcoal.Text, out SavSet.SaveCharcoal);
            double.TryParse(TBCostCoal.Text, out SavSet.SaveCoal);
            double.TryParse(TBCostEnria.Text, out SavSet.SaveEnria);
            double.TryParse(TBCostIronOre.Text, out SavSet.SaveIronOre);
            double.TryParse(TBCostMithrilOre.Text, out SavSet.SaveMithrilOre);
            double.TryParse(TBCostMoldGlue.Text, out SavSet.SaveMoldGlue);
            double.TryParse(TBCostMoldHardener.Text, out SavSet.SaveMoldHardener);
            double.TryParse(TBCostMoldLubricant.Text, out SavSet.SaveMoldLubricant);
            double.TryParse(TBCostOriharukonOre.Text, out SavSet.SaveOriharukonOre);
            double.TryParse(TBCostSilverNugget.Text, out SavSet.SaveSilverNugget);
            double.TryParse(TBCostStem.Text, out SavSet.SaveStem);
            double.TryParse(TBCostStoneOfPurity.Text, out SavSet.SaveStoneOfPurity);
            double.TryParse(TBCostSuede.Text, out SavSet.SaveSuede);
            double.TryParse(TBCostThons.Text, out SavSet.SaveThons);
            double.TryParse(TBCostThread.Text, out SavSet.SaveThread);
            double.TryParse(TBCostVarnish.Text, out SavSet.SaveVarnish);
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
            double.TryParse(TBCostBraidedHemp.Text, out SavSet.SaveBraidedHemp);
            double.TryParse(TBCostCoarseBonePowder.Text, out SavSet.SaveCoarsedBonePowder);
            double.TryParse(TBCostCokes.Text, out SavSet.SaveCokes);
            double.TryParse(TBCostCompoundBraid.Text, out SavSet.SaveCompoundBraid);
            double.TryParse(TBCostHighGradeSuede.Text, out SavSet.SaveHighGradeSuede);
            double.TryParse(TBCostLeather.Text, out SavSet.SaveLeather);
            double.TryParse(TBCostMetalHardener.Text, out SavSet.SaveMetalHardener);
            double.TryParse(TBCostMetallicThread.Text, out SavSet.SaveMetallicThread);
            double.TryParse(TBCostDurableMetalPlate.Text, out SavSet.SaveDurableMetalPlate);
            double.TryParse(TBCostSteel.Text, out SavSet.SaveSteel);
            double.TryParse(TBCostCord.Text, out SavSet.SaveCord);
            double.TryParse(TBCostMetallicFiber.Text, out SavSet.SaveMetallicFiber);
            double.TryParse(TBCostCraftedLeather.Text, out SavSet.SaveCraftedLeather);
            double.TryParse(TBCostSteelMold.Text, out SavSet.SaveSteelMold);
            double.TryParse(TBCostSyntheticCokes.Text, out SavSet.SaveSynteticCokes);
            double.TryParse(TBCostOriharukon.Text, out SavSet.SaveOriharukon);
            double.TryParse(TBCostVarnishOfPurity.Text, out SavSet.SaveVarnishOfPurity);
            double.TryParse(TBCostMithrilAlloy.Text, out SavSet.SaveMithrilAlloy);
            double.TryParse(TBCostSilverMold.Text, out SavSet.SaveSilverMold);
            double.TryParse(TBCostBlacksmithsFrame.Text, out SavSet.SaveBlacksmithsFrame);
            double.TryParse(TBCostArtisansFrame.Text, out SavSet.SaveArtisansFrame);
            double.TryParse(TBCostCraftsmanMold.Text, out SavSet.SaveCraftsmanMold);
            double.TryParse(TBCostArcsmithsAnvil.Text, out SavSet.SaveArcsmithsAnvil);
            double.TryParse(TBCostMaestroAnvilLock.Text, out SavSet.SaveMaestroAnvilLock);
            double.TryParse(TBCostLeolinsMold.Text, out SavSet.SaveLeolinsMold);
            double.TryParse(TBCostMaestroHolder.Text, out SavSet.SaveMaestroHolder);
            double.TryParse(TBCostMaestroMold.Text, out SavSet.SaveMaestroMold);
            double.TryParse(TBCostWarsmithsHolder.Text, out SavSet.SaveWarsmithsHolder);
            double.TryParse(TBCostWarsmithsMold.Text, out SavSet.SaveWarsmithsMold);

            //Револ
            double.TryParse(TBSwordOfRevolutionToCry.Text, out SavSet.SaveSwordOfRevolution);

            //АА
            double.TryParse(TBAncientAdenaToCry.Text, out SavSet.SaveAncientAdena);

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
                    TBCostAdamantiteNugget.Text = SavSet.SaveAdamantiteNugget.ToString("F0");
                    TBCostAnimalBone.Text = SavSet.SaveAnimalBone.ToString("F0");
                    TBCostAnimalSkin.Text = SavSet.SaveAnimalSkin.ToString("F0");
                    TBCostAsofe.Text = SavSet.SaveAsofe.ToString("F0");
                    TBCostCharcoal.Text = SavSet.SaveCharcoal.ToString("F0");
                    TBCostCoal.Text = SavSet.SaveCoal.ToString("F0");
                    TBCostEnria.Text = SavSet.SaveEnria.ToString("F0");
                    TBCostIronOre.Text = SavSet.SaveIronOre.ToString("F0");
                    TBCostMithrilOre.Text = SavSet.SaveMithrilOre.ToString("F0");
                    TBCostMoldGlue.Text = SavSet.SaveMoldGlue.ToString("F0");
                    TBCostMoldHardener.Text = SavSet.SaveMoldHardener.ToString("F0");
                    TBCostMoldLubricant.Text = SavSet.SaveMoldLubricant.ToString("F0");
                    TBCostOriharukonOre.Text = SavSet.SaveOriharukonOre.ToString("F0");
                    TBCostSilverNugget.Text = SavSet.SaveSilverNugget.ToString("F0");
                    TBCostStem.Text = SavSet.SaveStem.ToString("F0");
                    TBCostStoneOfPurity.Text = SavSet.SaveStoneOfPurity.ToString("F0");
                    TBCostSuede.Text = SavSet.SaveSuede.ToString("F0");
                    TBCostThons.Text = SavSet.SaveThons.ToString("F0");
                    TBCostThread.Text = SavSet.SaveThread.ToString("F0");
                    TBCostVarnish.Text = SavSet.SaveVarnish.ToString("F0");
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
                    TBCostBraidedHemp.Text = SavSet.SaveBraidedHemp.ToString("F0");
                    TBCostCoarseBonePowder.Text = SavSet.SaveCoarsedBonePowder.ToString("F0");
                    TBCostCokes.Text = SavSet.SaveCokes.ToString("F0");
                    TBCostCompoundBraid.Text = SavSet.SaveCompoundBraid.ToString("F0");
                    TBCostHighGradeSuede.Text = SavSet.SaveHighGradeSuede.ToString("F0");
                    TBCostLeather.Text = SavSet.SaveLeather.ToString("F0");
                    TBCostMetalHardener.Text = SavSet.SaveMetalHardener.ToString("F0");
                    TBCostMetallicThread.Text = SavSet.SaveMetallicThread.ToString("F0");
                    TBCostDurableMetalPlate.Text = SavSet.SaveDurableMetalPlate.ToString("F0");
                    TBCostSteel.Text = SavSet.SaveSteel.ToString("F0");
                    TBCostCord.Text = SavSet.SaveCord.ToString("F0");
                    TBCostMetallicFiber.Text = SavSet.SaveMetallicFiber.ToString("F0");
                    TBCostCraftedLeather.Text = SavSet.SaveCraftedLeather.ToString("F0");
                    TBCostSteelMold.Text = SavSet.SaveSteelMold.ToString("F0");
                    TBCostSyntheticCokes.Text = SavSet.SaveSynteticCokes.ToString("F0");
                    TBCostOriharukon.Text = SavSet.SaveOriharukon.ToString("F0");
                    TBCostVarnishOfPurity.Text = SavSet.SaveVarnishOfPurity.ToString("F0");
                    TBCostMithrilAlloy.Text = SavSet.SaveMithrilAlloy.ToString("F0");
                    TBCostSilverMold.Text = SavSet.SaveSilverMold.ToString("F0");
                    TBCostBlacksmithsFrame.Text = SavSet.SaveBlacksmithsFrame.ToString("F0");
                    TBCostArtisansFrame.Text = SavSet.SaveArtisansFrame.ToString("F0");
                    TBCostCraftsmanMold.Text = SavSet.SaveCraftsmanMold.ToString("F0");
                    TBCostArcsmithsAnvil.Text = SavSet.SaveArcsmithsAnvil.ToString("F0");
                    TBCostMaestroAnvilLock.Text = SavSet.SaveMaestroAnvilLock.ToString("F0");
                    TBCostLeolinsMold.Text = SavSet.SaveLeolinsMold.ToString("F0");
                    TBCostMaestroHolder.Text = SavSet.SaveMaestroHolder.ToString("F0");
                    TBCostMaestroMold.Text = SavSet.SaveMaestroMold.ToString("F0");
                    TBCostWarsmithsHolder.Text = SavSet.SaveWarsmithsHolder.ToString("F0");
                    TBCostWarsmithsMold.Text = SavSet.SaveWarsmithsMold.ToString("F0");

                    //Револ
                    TBSwordOfRevolutionToCry.Text = SavSet.SaveSwordOfRevolution.ToString("F0");

                    //АА
                    TBAncientAdenaToCry.Text = SavSet.SaveAncientAdena.ToString("F0");

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


        private void TabComponents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabComponents.SelectedIndex == 0)
            {
                LabHelp.Text = "Не забывайте сохранять изменения. Вводить все цены заново - не очень приятно ;)";
            }
            if (TabComponents.SelectedIndex == 1)
            {
                LabHelp.Text = "При расчете стоимости Кристаллов B-Grade учитывается стоимость Stone Of Purity.";
            }
        }

        private void TBCostSSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void WBReklamaTabCry_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
