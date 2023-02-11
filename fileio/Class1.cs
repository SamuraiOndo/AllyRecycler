
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Yarhl.IO;
namespace fileio
{
    public class EnemyDisposeData
    {
        public float unk1;
        public string name;
        public ushort checksum;
        public string modelName;
        public string weapon;
        public ushort health;
        public ushort unk2;
        public ushort unk3;
        public byte height;
        public byte voiceBank;
        public byte type;
        public byte damage;
        public byte aiPreset;
        public float X;
        public float Y;
        public float Z;
        public float W;
        public ushort rotY;
        public ushort unk8;
        public string btl_st;
        public byte unk4;
        public byte unk5;
        public byte unk6;
        public byte unk7;

        public EnemyDisposeData(EnemyDisposeData node)
        {
            unk1 = node.unk1;
            name = node.name;
            checksum = node.checksum;
            modelName = node.modelName;
            weapon = node.weapon;
            health = node.health;
            unk2 = node.unk2;
            unk3 = node.unk3;
            height = node.height;
            voiceBank = node.voiceBank;
            type = node.type;
            damage = node.damage;
            aiPreset = node.aiPreset;
            X = node.X;
            Y = node.Y;
            Z = node.Z;
            W = node.W;
            rotY = node.rotY;
            unk8 = node.unk8;
            btl_st = node.btl_st;
            unk4 = node.unk4;
            unk5 = node.unk5;
            unk6 = node.unk6;
            unk7 = node.unk7;
        }
        public EnemyDisposeData() {
            unk1 = 0;
            name = "NewNode";
            checksum = 0;
            modelName = "";
            weapon = "";
            health = 0;
            unk2 = 0;
            unk3 = 0;
            height = 0;
            voiceBank = 0;
            type = 0;
            damage = 0;
            aiPreset = 0;
            X = 0;
            Y = 0;
            Z = 0;
            W = 0;
            rotY = 0;
            unk8 = 0;
            btl_st = "";
            unk4 = 0;
            unk5 = 0;
            unk6 = 0;
            unk7 = 0;

        }

    }
    public class HeaderData
    {
        public uint versionNum;
        public uint count;
        public uint fileNameCount;
        public uint propertySize;
        public uint flags1;
        public uint flags2;
        public uint flags3;
    }
    public class file
    {
        public static HeaderData headerData;
        public static List<EnemyDisposeData> enemyDisposeNodes = new List<EnemyDisposeData>();
        public static EnemyDisposeData enemyDisposeNode;
        public static string[] weaponArray = { "WEOTA0000", "WEOTA0004", "WEOTA0007", "WEOTA0010", "WEOTA0012", "WEOTA0013", "WECHI0000", "WECHI0001", "WECHI0002", "WECHI0003", "WEFUK0000", "WEFUK0001", "WEFUK0010", "WEFUK0011", "WEFUK0020", "WEFUK0021", "WEFUK0022", "WEFUK0023", "WEFUK0040", "WEFUK0041", "WEFUK0042", "WEFUK0043", "WEFUK0044", "WEFUK0045", "WEFUK0046", "WEFUK0047", "WEFUK0048", "WEFUK0049", "WEFUK0050", "WEFUK0051", "WEFUK0052", "WEFUK0053", "WEFUK0054", "WEFUK0055", "WEFUK0056", "WEFUK0057", "WEFUK0058", "WEFUK0059", "REHAM0005", "REHAM0010", "REHAM0015", "REHAM0020", "REHAM0025", "REHAM0030", "REHAM0031", "REHAM0032", "REHAM0033", "REHAM0035", "REHAM0040", "REHAM0041", "REHAM0042", "REHAM0043", "REHAM0045", "REHAM0046", "REHAM0050", "REHAM0051", "REHAM0055", "REHAM0056", "REHAM0057", "REHAM0058", "REHAM0060", "REHAM0061", "REHAM0065", "REHAM0066", "REHAM0067", "REHAM0068", "REHAM0070", "REHAM0071", "REHAM0072", "REHAM0073", "REHAM0075", "REHAM0076", "REHAM0080", "REHAM0081", "REHAM0085", "REHAM0086", "REHAM0087", "REHAM0088", "REHAM0090", "REHAM0091", "REHAM0095", "REHAM0096", "REHAM0100", "REHAM0101", "REHAM0102", "REHAM0103", "REHAM0105", "REHAM0106", "REHAM0110", "REHAM0111", "REHAM0112", "REHAM0113", "REHAM0115", "REHAM0116", "REHAM0117", "REHAM0118", "REHAM0120", "REHAM0121", "REHAM0122", "REHAM0123", "REHAM0125", "REHAM0126", "REHAM0127", "REHAM0128", "REHAM0130", "REHAM0131", "REHAM0132", "REHAM0133", "REHAM0135", "REHAM0136", "REHAM0137", "REHAM0138", "WEHAM0000", "WEHAM0010", "WEHAM0015", "WEHAM0016", "WEHAM0017", "WEHAM0018", "WEHAM0020", "WEHAM0021", "WEHAM0022", "WEHAM0023", "WEHAM0025", "WEHAM0026", "WEHAM0027", "WEHAM0028", "WEHAM0030", "WEHAM0031", "WEHAM0035", "WEHAM0036", "WEHAM0040", "WEHAM0041", "WEHAM0045", "WEHAM0046", "WEHAM0050", "WEHAM0051", "WEHAM0055", "WEHAM0056", "WEHAM0057", "WEHAM0058", "WEHAM0060", "WEHAM0061", "WEHAM0062", "WEHAM0063", "WEHAM0065", "WEHAM0066", "WEHAM0067", "WEHAM0068", "REHIR0000", "REHIR0001", "REHIR0002", "REHIR0003", "REHIR0004", "REHIR0005", "REHIR0006", "REHIR0007", "REHIR0008", "REHIR0009", "REHIR0010", "WEHIR0000", "WEHIR0001", "WEHIR0002", "WEHIR0003", "WEHIR0004", "WEHIR0005", "WEHIR0006", "WEHIR0007", "WEHIR0008", "WEHIR0009", "WEHIR0010", "WEHIR0011", "WEHIR0012", "WEHIR0013", "WEHIR0014", "WEHIR0015", "WEHIR0016", "WEHIR0017", "WEHIR0018", "WEHIR0019", "WEHIR0020", "WEHIR0021", "WEHIR0022", "WEHIR0023", "WEHIR0024", "WEHIR0025", "WEHIR0026", "WEHIR0027", "WEKAK0000", "WEKAK0001", "WEKAK0002", "RENAK0000", "RENAK0001", "RENAK0002", "RENAK0003", "WENAK0001", "WENAK0002", "WENAK0003", "WENAK0004", "WENAK0005", "WENAK0006", "WENAK0007", "WENAK0008", "WENAK0009", "WENAK0010", "WENAK0011", "WENAK0012", "WENAK0013", "WENAK0014", "WENAK0015", "WENAK0016", "WENAK0017", "WENAK0018", "WENAK0019", "WENAK0020", "WENAK0021", "WENAK0022", "WENAK0023", "WENAK0024", "WENAK0025", "WENAK0026", "WENAK0027", "WENAK0028", "WENAK0029", "WENAK0030", "WENAK0031", "WENAK0032", "WENAK0033", "WENAS3017", "WENIS0000", "WENIS0001", "WENIS0005", "WENIS0006", "WENIS0010", "WENIS0011", "WENIS0015", "WENIS0016", "WENIS0020", "WENIS0021", "WENIS0025", "WENIS0026", "WENIS0030", "WENIS0031", "WENIS0035", "WENIS0036", "WENIS0040", "WENIS0041", "WENIS0100", "WENIS0101", "WENIS0105", "WENIS0106", "WENIS0110", "WENIS0111", "WENIS0115", "WENIS0116", "WENIS0120", "WENIS0121", "WENIS0130", "REODA0000", "REODA0001", "REODA0002", "REODA0003", "REODA0004", "REODA0005", "REODA0006", "REODA0007", "REODA0008", "REODA0009", "REODA0010", "REODA0011", "REODA0012", "REODA0013", "REODA0014", "REODA0015", "REODA0016", "REODA0017", "REODA0018", "REODA0019", "REODA0020", "REODA0021", "REODA0030", "WEODA0000", "WEODA0001", "WEODA0002", "WEODA0003", "WEODA0004", "WEODA0005", "WEODA0006", "WEODA0007", "WEODA0008", "WEODA0009", "WEODA0010", "WEODA0011", "WEODA0012", "WEODA0013", "WEODA0014", "WEODA0015", "WEODA0016", "WEODA0017", "WEODA0018", "WEODA0019", "WEODA0020", "WEODA0021", "WEODA0022", "WEODA0023", "WEODA0024", "WEODA0025", "WEODA0026", "WEODA0027", "WEODA0028", "WEODA0029", "WEODA0030", "WEODA0031", "WEODA0032", "WEODA0033", "WEODA0034", "WEODA0035", "WEODA0036", "WEODA0037", "WEODA0038", "WEODA0039", "WEODA0040", "WEODA0041", "WEODA0042", "WEODA0043", "WEODA0044", "WEODA0045", "WEODA0046", "WEODA0047", "WEODA0048", "WEODA0049", "WEODA0050", "WEODA0051", "WEODA0052", "WEODA0053", "WEODA0054", "WEODA0055", "WEODA0056", "WEODA0057", "WEODA0058", "WEODA0059", "WEODA0060", "WEODA0061", "WEODA0062", "WEODA0063", "WEODA0064", "WEODA0065", "WEODA0066", "WEODA0067", "WEODA0068", "WEODA0069", "WEODA0070", "WEODA0071", "WEODA0072", "WEODA0073", "WEODA0074", "WEODA0075", "WEODA0076", "WEODA0077", "WEODA0078", "WEODA0079", "WEODA0080", "WEODA0081", "WEODA0082", "WEODA0083", "WEODA0084", "WEODA0085", "WEODA0086", "WEODA0087", "WEODA0088", "WEODA0089", "WEODA0090", "WEODA0091", "WEODA0092", "WEODA0093", "WEODA0094", "WEODA0095", "WEODA0096", "WEODA0097", "WEODA0098", "WEODA0099", "WEODA0100", "WEODA0101", "WEODA0102", "WEODA0103", "WEODA0104", "WEODA0105", "WEODA0106", "WEODA0107", "WEODA0108", "WEODA0109", "WEODA0110", "WEODA0111", "WEODA0112", "WEODA0113", "WEODA0114", "WEODA0115", "WEODA0116", "WEODA0117", "WEODA0118", "WEODA0119", "WEODA0120", "WEODA0121", "WEODA0122", "WEODA0123", "WEODA0124", "WEODA0125", "WEODA0126", "WEODA0127", "WEODA0128", "WEODA0129", "WEODA0130", "WEODA0131", "WEODA0132", "WEODA0133", "WEODA0134", "WEODA0135", "WEODA0136", "WEODA0137", "WEODA0138", "WEODA0139", "WEODA0140", "WEODA0141", "WEODA0142", "WEODA0143", "WEODA0144", "WEODA0145", "WEODA0146", "WEODA0147", "WEODA0148", "WEODA0149", "WEODA0150", "WEODA0151", "WEODA0152", "WEODA0153", "WEODA0154", "WEODA0155", "WEODA0156", "WEODA0157", "WEODA0158", "WEODA0159", "WEODA0160", "WEODA0161", "WEODA0162", "WEODA0163", "WEODA0164", "WEODA0165", "WEODA0166", "WEODA0167", "WEODA0168", "WEODA0169", "WEODA0170", "WEODA0171", "WEODA0172", "WEODA0173", "WEODA0174", "WEODA0175", "WEODA0176", "WEODA0177", "WEODA0178", "WEODA0179", "WEODA0180", "WEODA0181", "WEODA0182", "WEODA0183", "WEODA0184", "WEODA0185", "WEODA0186", "WEODA0187", "WEODA0188", "WEODA0189", "WEODA0190", "WEODA0191", "WEODA0192", "WEODA0193", "WEODA0194", "WEODA0195", "WEODA0196", "WEODA0197", "WEODA0198", "WEODA0199", "WEODA0200", "WEODA0201", "WEODA0202", "WEODA0203", "WEODA0204", "WEODA0205", "WEODA0206", "WEODA0207", "WEODA0208", "WEODA0209", "WEODA0210", "WEODA0211", "WEODA0212", "WEODA0213", "WEODA0214", "WEODA0215", "WEODA0216", "WEODA0217", "WEODA0218", "WEODA0219", "WEODA0220", "WEODA0221", "WEODA0222", "WEODA0223", "WEODA0224", "WEODA0225", "WEODA0226", "WEODA0227", "WEODA0228", "WEODA0229", "WEODA0230", "WEODA0231", "WEODA0232", "WEODA0233", "WEODA0234", "WEODA0235", "WEODA0236", "WEODA0237", "WEODA0238", "WEODA0239", "WEODA0240", "WEODA0241", "WEODA0242", "WEODA0243", "WEODA0244", "WEODA0245", "WEODA0246", "WEODA0247", "WEODA0248", "WEODA0249", "WEODA0250", "WEODA0251", "WEODA0252", "WEODA0253", "WEODA0254", "WEODA0255", "WEODA0256", "WEODA0257", "WEODA0258", "WEODA0259", "WEODA0260", "WEODA0261", "WEODA0262", "WEODA0263", "WEODA0264", "WEODA0265", "WEODA0266", "WEODA0267", "WEODA0268", "WEODA0269", "WEODA0270", "WEODA0271", "WEODA0272", "WEODA0273", "WEODA0274", "WEODA0275", "WEODA0276", "WEODA0277", "WEODA0278", "WEODA0279", "WEODA0280", "WEODA0281", "WEODA0282", "WEODA0283", "WEODA0284", "WEODA0285", "WEODA0286", "WEODA0287", "WEODA0288", "WEODA0289", "WEODA0290", "WEODA0291", "WEODA0292", "WEODA0293", "WEODA0294", "WEODA0295", "WEODA0296", "WEODA0297", "WEODA0298", "WEODA0299", "WEODA0300", "WEODA0301", "WEODA0302", "WEODA0303", "WEODA0304", "WEODA0305", "WEODA0306", "WEODA0307", "WEODA0308", "WEODA0309", "WEODA0310", "WEODA0311", "WEODA0312", "WEODA0313", "WEODA0314", "WEODA0315", "WEODA0316", "WEODA0317", "WEODA0318", "WEODA0319", "WEODA0320", "WEODA0321", "WEODA0322", "WEODA0323", "WEODA0324", "WEODA0325", "WEODA0326", "WEODA0327", "WEODA0328", "WEODA0329", "WEODA0330", "WEODA0331", "WEODA0332", "WEODA0333", "WEODA0334", "WEODA0335", "WEODA0336", "WEODA0337", "WEODA0338", "WEODA0339", "WEODA0340", "WEODA0341", "WEODA0342", "WEODA0343", "WEODA0344", "WEODA0345", "WEODA0346", "WEODA0347", "WEODA0348", "WEODA0350", "WEODA0351", "WEODA0352", "WEODA0353", "WEODA0354", "REOKA0000", "REOKA0005", "REOKA0010", "REOKA0015", "REOKA0020", "REOKA0025", "REOKA0030", "REOKA0035", "REOKA0040", "REOKA0045", "REOKA0050", "REOKA0055", "REOKA0060", "REOKA0061", "REOKA0065", "REOKA0066", "REOKA0070", "REOKA0071", "REOKA0075", "REOKA0076", "REOKA0080", "REOKA0085", "REOKA0090", "REOKA0095", "REOKA0096", "REOKA0097", "REOKA0100", "REOKA0101", "REOKA0102", "REOKA0105", "REOKA0106", "REOKA0110", "REOKA0115", "REOKA0120", "REOKA0125", "REOKA0130", "REOKA0135", "REOKA0140", "REOKA0145", "REOKA0150", "REOKA0155", "REOKA0160", "REOKA0165", "REOKA0170", "REOKA0175", "WEOKA0000", "WEOKA0001", "WEOKA0002", "WEOKA0003", "WEOKA0004", "WEOKA0005", "WEOKA0006", "WEOKA0010", "WEOKA0015", "WEOKA0020", "WEOKA0025", "WEOKA0030", "WEOKA0035", "WEOKA0040", "WEOKA0045", "WEOKA0050", "WEOKA0055", "WEOKA0060", "WEOKA0065", "WEOKA0070", "WEOKA0075", "WEOKA0080", "WEOKA0085", "WEOKA0090", "WEOKA0100", "WEOKA0105", "WEOKA0110", "WEOKA0115", "WEOKA0120", "WEOKA0125", "WEOKA0130", "WEOKA0135", "WEOKA0140", "WEOKA0145", "WEOKA0150", "WEOKA0155", "WEOKA7030", "WEOKA7050", "WEOKA7051", "WEOKA7055", "WEOKA7056", "WEOKA7060", "WEOKA7061", "WEOKA7065", "WEOKA7066", "WEOKA7070", "WEOKA7071", "WEOKA7075", "WEOKA7076", "WEOKA7150", "WEOKA8002", "WEOKA8006", "WEOKA8010", "WEOKA8025", "WEOKA8030", "WEOKA8031", "WEOKA8035", "WEOKA8040", "WEOKA8045", "WEOKA8050", "WEOKA8051", "WEOKA8055", "WEOKA8056", "WEOKA8060", "WEOKA8061", "WEOKA8065", "WEOKA8066", "WEOKA8070", "WEOKA8071", "WEOKA8075", "WEOKA8076", "WEOKA8080", "WEOKA8085", "WEOKA8090", "WEOKA8100", "WEOKA8105", "WEOKA8110", "WEOKA8115", "WEOKA8120", "WEOKA8125", "WEOKA8130", "WEOKA8135", "WEOKA8140", "WEOKA8145", "WEOKA8150", "WEOKA8151", "WEOKA8155", "WEOKA8160", "WEOKA8165", "WEOKA8170", "WEOKA9000", "WEOKA9001", "WEOKA9002", "WEOKA9003", "WEOKA9004", "WEOKA9005", "WEOKA9015", "WEOKA9020", "WEOKA9050", "WEOKA9055", "WEOKA9060", "WEOKA9065", "WEOKA9070", "WEOKA9075", "WEOKA9080", "WEOKA9085", "WEOKU0000", "WEOKU0001", "WEOKU0002", "WEOKU0003", "WEOKU0004", "WEOKU0005", "WEOKU0006", "WEOKU0007", "WEOKU0008", "WEOKU0009", "WEOKU0010", "WEOKU0011", "WEOKU0012", "WEOKU0013", "WEOKU0014", "WEOKU0015", "WEOKU0016", "WEOKU0017", "WEOKU0018", "WEOKU0019", "WEOND0001", "WEOND0100", "WEOND0101", "WEOND0102", "WEOND0105", "WEOND0200", "WEOND0201", "WEOND0202", "WEOND1001", "WEOND1002", "WEOND1003", "WEOND1602", "WEOND3005", "WEOND3017", "WEOND3018", "WEOND3020", "WEOND3033", "WEOND3037", "WEOND3040", "WEOND9200", "WEOND9201", "WEOND9202", "WETAK0001", "WETAK0103", "WETAK0104", "WETAK1000", "WETAK1600", "WETAK1601", "WETAK3001", "WETAK3008", "WETAK3022", "WETAK9103", "WETAK9301", "WEORI0001", "WEORI0002", "WEORI0004", "WEORI0005", "WEORI0007", "WEORI0009", "WEORI0010", "WEORI0013", "WEORI0016", "WEORI0020", "WEORI0022", "WEORI0024", "WEORI0025", "WEORI0026", "WEORI0100", "WEORI0101", "WEORI0102", "WEORI0103", "WEORI0104", "WEORI0105", "WEORI0106", "WEORI0107", "WEORI0200", "WEORI0201", "WEORI0202", "WEORI0203", "WEORI0204", "WEORI0205", "WEORI0206", "WEORI0207", "WEORI0208", "WEORI0209", "WEORI0210", "WEORI0211", "WEORI0220", "WEORI0221", "WEORI0299", "WEORI0400", "WEORI0401", "WEORI0402", "WEORI0403", "WEORI0420", "WEORI0421", "WEORI0422", "WEORI0498", "WEORI0499", "WEORI0500", "WEORI0501", "WEORI0502", "WEORI0503", "WEORI0504", "WEORI0505", "WEORI0506", "WEORI0507", "WEORI0508", "WEORI0509", "WEORI0510", "WEORI0511", "WEORI0599", "WEORI0700", "WEORI0701", "WEORI0702", "WEORI0799", "WEORI0900", "WEORI0901", "WEORI0902", "WEORI0903", "WEORI0904", "WEORI0905", "WEORI0906", "WEORI0999", "WEORI1000", "WEORI1001", "WEORI1002", "WEORI1003", "WEORI1300", "WEORI1301", "WEORI1302", "WEORI1303", "WEORI1304", "WEORI1305", "WEORI1399", "WEORI1600", "WEORI1601", "WEORI1602", "WEORI1603", "WEORI1604", "WEORI2000", "WEORI2001", "WEORI2002", "WEORI2003", "WEORI2004", "WEORI2005", "WEORI2099", "WEORI2200", "WEORI2201", "WEORI2202", "WEORI2203", "WEORI2204", "WEORI2205", "WEORI2299", "WEORI2400", "WEORI2401", "WEORI2402", "WEORI2403", "WEORI2404", "WEORI2405", "WEORI2406", "WEORI2407", "WEORI2408", "WEORI2409", "WEORI2499", "WEORI2500", "WEORI2501", "WEORI2502", "WEORI2503", "WEORI2599", "WEORI3000", "WEORI3001", "WEORI3002", "WEORI3003", "WEORI3004", "WEORI3005", "WEORI3006", "WEORI3007", "WEORI3008", "WEORI3009", "WEORI3010", "WEORI3011", "WEORI3012", "WEORI3013", "WEORI3014", "WEORI3015", "WEORI3016", "WEORI3017", "WEORI3018", "WEORI3019", "WEORI3020", "WEORI3021", "WEORI3022", "WEORI3023", "WEORI3024", "WEORI3025", "WEORI3026", "WEORI3027", "WEORI3028", "WEORI3029", "WEORI3030", "WEORI3031", "WEORI3032", "WEORI3033", "WEORI3034", "WEORI3035", "WEORI3036", "WEORI3037", "WEORI3040", "WEORI3041", "WEORI3042", "WEORI3043", "WEORI5000", "WEORI5010", "WEORI5011", "WEORI5012", "WEORI5013", "WEORI5020", "WEORI5021", "WEORI5022", "WEORI5023", "WEORI5030", "WEORI5031", "WEORI5032", "WEORI5033", "REOTA1000", "REOTA1001", "REOTA1002", "REOTA1003", "REOTA1004", "REOTA1005", "REOTA1006", "REOTA1007", "REOTA1008", "REOTA1009", "REOTA1010", "REOTA1011", "REOTA1012", "REOTA1013", "REOTA1014", "REOTA1015", "WEOTA0001", "WEOTA0002", "WEOTA1002", "WEOTA1003", "WEOTA1102", "WEOTA1103", "WEOTA1602", "WEOTA2005", "WEOTA3014", "WEOTA3015", "WEOTA3016", "WEOTA3040", "WEOTA3041", "WEOTA3042", "WEOTA3043", "WESAK0001", "WESAK0002", "WESAK0003", "WESAK0004", "WESAK0005", "WESAK0006", "WESAK0007", "WESAK0008", "WESAK0010", "WESAK0011", "WESAK0012", "WESAK0013", "WESAK0014", "WESAK0015", "WESAK0020", "WESAK0021", "WESAK0030", "WESAK0031", "WESAK0032", "WESAK0033", "WESIM0010", "WESIM0011", "WESIM0020", "WESIM0021", "WESIM0030", "WESIM0031", "WESIM0040", "WESIM0041", "WESIM0045", "WESIM0050", "WESIM0051", "WESIM0055", "WESIM0060", "WESIM0061", "WESIM0065", "WESIM0070", "WESIM0080", "RESOM0000", "RESOM0001", "RESOM0002", "RESOM0003", "RESOM0004", "WESOM0000", "WESOM0001", "WESOM0002", "WESOM0003", "WESOM0004", "WESOM0005", "WESOM0006", "WESOM0007", "WESOM0008", "WESOM0009", "WESOM0010", "WESOM0011", "WESOM0012", "WESOM0013", "RESUD0000", "RESUD0001", "RESUD0002", "RESUD0003", "RESUD0004", "RESUD0005", "RESUD0006", "RESUD0007", "RESUD0008", "RESUD0009", "WETAK0504", "WETAK0700", "WETAK0701", "WETAK0702", "WETAK0799", "WETAK0902", "WETAK0903", "WETAK0904", "WETAK0905", "WETAK0906", "WETAK0999", "WETAK2000", "WETAK2001", "WETAK2002", "WETAK2003", "WETAK2004", "WETAK2005", "WETAK2099", "WETAK2403", "WETAK2404", "WETAK2405", "WETAK2406", "WETAK2407", "WETAK3024", "WETAK3026", "WETAK3027", "WETAK3028", "WETAK9200", "WETAK9203", "WETAK9204", "WETAK9220", "WETAK9221", "WETAK9222", "WETAK9224", "WETAK9225", "WETAK9229", "WETAK9243", "WETAK9245", "WETAK9246", "WETAK9247", "WETAK9299", "WETAK9328", "WETAK9504", "WETAK9700", "WETAK9902", "WETAK9903", "WETAK9905", "WETAK9999", "WETAN0010", "WETAN0011", "WETUN0010", "WETUN0011", "WETUN0020", "WETUN0021", "WETUN0030", "WETUN0031", "WETUN0040", "WETUN0041", "WETUN0050", "WETUN0051", "WETUN0060", "WETUN0061", "WETUN0070", "WETUN0071", "WETUN0080", "WETUN0081", "WETUN0090", "WETUN0091", "WETUN0100", "WETUN0101", "WETUN0110", "WETUN0111", "WETUN0120", "WETUN0121", "WETUN0130", "WETUN0131", "WETUN0140", "WETUN0141", "WETUN0150", "WETUN0160", "WETUN0170", "WETUN0180", "WETUN0190", "WETUN0191", "WETUN0200", "WETUN0201", "WETUN0202", "WETUN0203", "WETUN0210", "WETUN0211", "WETUN0212", "WETUN0220", "WETUN0221", "REUED0001", "REUED0002", "REUED0005", "REUED0006", "REUED0011", "REUED0012", "REUED0015", "REUED0016", "REUED0017", "REUED0021", "REUED0022", "REUED0025", "REUED0026", "WEUED0001", "WEUED0002", "WEUED0003", "WEUED0004", "WEUED0005", "WEUED0006", "WEUED0011", "WEUED0012", "WEUED0015", "WEUED0016", "WEUED0021", "WEUED0022", "WEUED0025", "WEUED0026", "WEUED0031", "WEUED0032", "WEUED0035", "WEUED0036", "WEUED0041", "WEUED0042", "WEUED0046", "WEUED0047", "WEUED0051", "WEUED0052", "WEUED0055", "WEUED0061", "WEUED0062", "WEUED0065", "WEUED0066", "WEUED0071", "WEUED0072", "WEUED0075", "WEUED0076", "WEUED0081", "WEUED0082", "WEUED0085", "WEUED0086", "WEUED0091", "WEUED0092", "WEUED0093", "REYAM0000", "REYAM0001", "REYAM0100", "REYAM1000", "REYAM1001", "REYAM1002", "REYAM1003", "REYAM1004", "REYAM1010", "REYAM1011", "REYAM1012", "REYAM1100", "REYAM1200", "REYAM1500", "REYAM2000", "REYAM3001", "REYAM3002", "REYAM3003", "REYAM3004", "REYAM3005", "REYAM3006", "REYAM3007", "REYAM3008", "REYAM3009", "REYAM3010", "REYAM3011", "REYAM3012", "REYAM3013", "REYAM3014", "REYAM3015", "REYAM3016", "REYAM3017", "REYAM3018", "REYAM3019", "REYAM3020", "REYAM3300", "REYAM3301", "REYAM3302", "REYAM3500", "REYAM3501", "REYAM3600", "REYAM4008", "REYAM4009", "REYAM4020", "REYAM4023", "REYAM5001", "REYAM5002", "REYAM5003", "REYAM5004", "REYAM5005", "REYAM5006", "REYAM5007", "REYAM5008", "REYAM5009", "REYAM5010", "REYAM5011", "REYAM5012", "REYAM5013", "REYAM5014", "REYAM5015", "REYAM5016", "REYAM5017", "REYAM5018", "REYAM5019", "REYAM5020", "REYAM5021", "REYAM5022", "REYAM5023", "REYAM5024", "REYAM5025", "REYAM5026", "REYAM5027", "REYAM5028", "REYAM5029", "REYAM5030", "REYAM5031", "REYAM5032", "REYAM5033", "REYAM5034", "REYAM5051", "REYAM5052", "REYAM5060", "REYAM5500", "REYAM5501", "REYAM5502", "REYAM5503", "REYAM5504", "REYAM5505", "REYAM5506", "REYAM5507", "REYAM5508", "REYAM7000", "REYAM9000", "REYAM9100", "REYAM9200", "REYAM9300", "WEYAM0007", "WEYAM0008", "WEYAM0019", "WEYAM0020", "WEYAM0022", "WEYAM0023", "WEYAM0024", "WEYAM0025", "WEYAM0026", "WEYAM0027", "WEYAM0028", "WEYAM0029", "WEYAM0030", "WEYAM0031", "WEYAM0032", "WEYAM0033", "WEYAM0034", "WEYAM0035", "WEYAM0036", "WEYAM0038", "WEYAM0039", "WEYAM0040", "WEYAM0041", "WEYAM0042", "WEYAM0043", "WEYAM0044", "WEYAM0045", "WEYAM0050", "WEYAM0051", "WEYAM0062", "WEYAM0063", "WEYAM0064", "WEYAM0065", "WEYAM0066", "WEYAM0067", "WEYAM0068", "WEYAM0070", "WEYAM0072", "WEYAM0073", "WEYAM0088", "WEYAM0089", "WEYAM0090", "WEYAM0098", "WEYAM0300", "WEYAM0500", "WEYAM0501", "WEYAM1000", "WEYAM1001", "WEYAM1002", "WEYAM1003", "WEYAM1004", "WEYAM1005", "WEYAM1006", "WEYAM1007", "WEYAM1008", "WEYAM1010", "WEYAM1011", "WEYAM1012", "WEYAM1013", "WEYAM2012", "WEYAM2013", "WEYAM2014", "WEYAM2015", "WEYAM2016", "WEYAM2017", "WEYAM2018", "WEYAM2019", "WEYAM2020", "WEYAM2021", "WEYAM2023", "WEYAM2025", "WEYAM2030", "WEYAM2050", "WEYAM2051", "WEYAM2073", "WEYAM2084", "WEYAM2088", "WEYAM2090", "WEYAM2100", "WEYAM2300", "WEYAM3000", "WEYAM3001", "WEYAM3002", "WEYAM3003", "WEYAM3004", "WEYAM3005", "WEYAM3006", "WEYAM3007", "WEYAM3008", "WEYAM3009", "WEYAM3010", "WEYAM3011", "WEYAM3012", "WEYAM3013", "WEYAM3014", "WEYAM3015", "WEYAM4020", "WEYAM5001", "WEYAM5002", "WEYAM5003", "WEYAM5004", "WEYAM5009", "WEYAM5010", "WEYAM5016", "WEYAM5023", "WEYAM5034", "WEYAM5036", "WEYAM5100", "WEYAM5106", "WEYAM7000", "WEYAM8000", "WEYAM8001", "WEYAM8100", "WEYAM9000", "WEYAM9001", "WEYAM9002", "WEYAM9003", "WEYAM9004", "WEYAM9005", "WEYAM9006", "WEYAM9007", "WEYAM9008", "WEYAM9009", "WEYAM9010", "WEYAM9011", "WEYAM9012", "WEYAM9013", "REZAM0001", "REZAM0002", "REZAM0003", "REZAM0004", "REZAM0005", "REZAM0006", "WEYAM0012", "WEYAM0013", "WEYAM0014", "WEYAM0015", "WEYAM0016", "WEYAM0017", "WEYAM0018", "WEYAM0021", "WEYAM2033", "WEYAM2034", "WEYAM2035", "WEYAM2036", "WEYAM2038", "WEYAM2039", "WEYAM2040", "WEYAM2041", "WEYAM2042", "WEYAM2043", "WEYAM2044", "WEYAM2045", "WEZAM0001", "WEZAM0002", "WEZAM0003", "WEZAM0004", "WEZAM0005", "WEZAM0006", "WEZAM0007", "WEZAM0008", "WEZAM0009", "WEZAM0010", "WEZAM0011", "WEZAM0012", "WEZAM0013", "WEZAM0014", "WEZAM0015", "WEZAM0016", "WEZAM0017", "WEZAM0018", "WEZAM0019", "WEZAM0020", "WEZAM0021", "WEZAM0022", "WEZAM0023", "WEZAM0024", "WEZAM0025", "WEZAM0026", "WEZAM0027", "WEZAM0028", "WEZAM0029", "WEZAM0030", "WEZAM0031", "WEZAM0032", "WEZAM0033", "WEZAM0034", "WEZAM0035", "WEZAM0036" };
        public uint weaponIndex;
        public static void ReadFile(string path)
        {
            enemyDisposeNodes.Clear();
            using (var stream = DataStreamFactory.FromFile(path, FileOpenMode.Read))
            {
                var reader = new DataReader(stream)
                {
                    DefaultEncoding = Encoding.GetEncoding("shift-jis"),
                    Endianness = EndiannessMode.BigEndian,
                };
                headerData = ReadHeader(reader);
                for (int i = 0; i < headerData.count; i++)
                {
                    enemyDisposeNode = ReadStruct(reader);
                    enemyDisposeNodes.Add(enemyDisposeNode);
                }

            }
            
        }
        
        public static EnemyDisposeData ReadStruct(DataReader reader)
        {
            EnemyDisposeData nodeData = new EnemyDisposeData();
            float unk1 = reader.ReadSingle();
            string name = reader.ReadString(36);
            ushort checksum = reader.ReadUInt16();
            string modelName = reader.ReadString(30);
            string weapon = reader.ReadString(10);
            ushort health = reader.ReadUInt16();
            ushort unk2 = reader.ReadUInt16();
            uint pad = reader.ReadUInt16();
            ushort unk3 = reader.ReadUInt16();
            uint pad1 = reader.ReadByte();
            byte height = reader.ReadByte();
            uint pad2 = reader.ReadByte();
            byte voiceBank = reader.ReadByte();
            byte type = reader.ReadByte();
            byte damage = reader.ReadByte();
            byte aiPreset = reader.ReadByte();
            int pad3 = reader.ReadInt24();
            int pad4 = reader.ReadInt32();
            int pad5 = reader.ReadInt32();
            int pad6 = reader.ReadInt32();
            float X = reader.ReadSingle();
            float Y = reader.ReadSingle();
            float Z = reader.ReadSingle();
            float W = reader.ReadSingle();
            ushort rotY = reader.ReadUInt16();
            ushort pad7 = reader.ReadUInt16();
            string btl_st = reader.ReadString(32);
            byte unk4 = reader.ReadByte();
            byte unk5 = reader.ReadByte();
            byte unk6 = reader.ReadByte();
            byte unk7 = reader.ReadByte();
            int pad8 = reader.ReadInt32();
            int pad9 = reader.ReadInt32();
            nodeData.unk1 = unk1;
            nodeData.name = name;
            nodeData.checksum= checksum;
            nodeData.modelName = modelName;
            nodeData.weapon = weapon.Split(new[] { '\0' }, 2)[0]; ;
            nodeData.health = health;
            nodeData.unk2= unk2;
            nodeData.unk3= unk3;
            nodeData.height= height;
            nodeData.voiceBank= voiceBank;
            nodeData.type = type;
            nodeData.damage= damage;
            nodeData.aiPreset= aiPreset;
            nodeData.X = X;
            nodeData.Y= Y;
            nodeData.Z = Z;
            nodeData.W = W;
            nodeData.rotY = rotY;
            nodeData.btl_st= btl_st;
            nodeData.unk4= unk4;
            nodeData.unk5= unk5;
            nodeData.unk6= unk6;
            nodeData.unk7 = unk7;
            nodeData.unk8 = pad7;
            return nodeData;
        }
        public static HeaderData ReadHeader(DataReader reader)
        {
            HeaderData headerData = new HeaderData();
            uint versionNum = reader.ReadUInt32();
            uint count = reader.ReadUInt32();
            uint fileNameCount = reader.ReadUInt32();
            uint propertySize = reader.ReadUInt32();
            uint flags1 = reader.ReadUInt32();
            uint flags2 = reader.ReadUInt32();
            uint flags3 = reader.ReadUInt32();
            headerData.versionNum = versionNum;
            headerData.count = count;
            headerData.fileNameCount = fileNameCount;
            headerData.propertySize = propertySize;
            headerData.flags1 = flags1;
            headerData.flags2 = flags2;
            headerData.flags3 = flags3;
            return headerData;
        }
        public static void saveFile(string path)
        {
            using (var stream = DataStreamFactory.FromFile(path, FileOpenMode.Write))
            {
                var writer = new DataWriter(stream)
                {
                    DefaultEncoding = Encoding.GetEncoding("shift-jis"),
                    Endianness = EndiannessMode.BigEndian,
                };
                SaveHeader(writer);
                SaveFile(writer, Encoding.GetEncoding("shift-jis"));
                
            }
        }
        public static void SaveHeader(DataWriter w)
        {
            w.Write(headerData.versionNum);
            w.Write(headerData.count);
            w.Write(headerData.fileNameCount);
            w.Write(headerData.propertySize);
            w.Write(headerData.flags1);
            w.Write(headerData.flags2);
            w.Write(headerData.flags3);
        }
        public static void SaveFile(DataWriter w, Encoding DefaultEncoding)
        {
            foreach(var i in enemyDisposeNodes)
            {
                w.Write(i.unk1);
                w.Write(i.name, false, DefaultEncoding, 36);
                byte[] ba = Encoding.GetEncoding(932).GetBytes(i.name);
                w.WriteTimes(0, (36 - ba.Length));
                w.Write(i.checksum);
                w.Write(i.modelName, false, DefaultEncoding, 30);
                byte[] bya = Encoding.GetEncoding(932).GetBytes(i.modelName);
                w.WriteTimes(0, (30 - bya.Length));
                w.Write(i.weapon, false, DefaultEncoding, 10);
                byte[] byta = Encoding.GetEncoding(932).GetBytes(i.weapon);
                w.WriteTimes(0, (10 - byta.Length));
                w.Write(i.health);
                w.Write(i.unk2);
                w.WriteTimes(0, 2);
                w.Write(i.unk3);
                w.WriteTimes(0, 1);
                w.Write(i.height);
                w.WriteTimes(0, 1);
                w.Write(i.voiceBank);
                w.Write(i.type);
                w.Write(i.damage);
                w.Write(i.aiPreset);
                w.WriteTimes(0, 15);
                w.Write(i.X);
                w.Write(i.Y);
                w.Write(i.Z);
                w.Write(i.W);
                w.Write(i.rotY);
                w.Write(i.unk8);
                w.Write(i.btl_st, false, DefaultEncoding, 32);
                byte[] bytea = Encoding.GetEncoding(932).GetBytes(i.btl_st);
                w.WriteTimes(0, (32 - bytea.Length));
                w.Write(i.unk4);
                w.Write(i.unk5);
                w.Write(i.unk6);
                w.Write(i.unk7);
                w.WriteTimes(0, 8);
            }
        }
    }
}
