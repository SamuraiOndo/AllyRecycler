
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
        public bool isYakuza4;
    }
    public class file
    {
        public static HeaderData headerData;
        public static List<EnemyDisposeData> enemyDisposeNodes = new List<EnemyDisposeData>();
        public static EnemyDisposeData enemyDisposeNode;
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
            headerData.isYakuza4 = versionNum == 12;
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
