using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;
using System.Text;
using System.IO.IsolatedStorage;

public class scorefile : MonoBehaviour
{
    public List<int> a = new List<int>() { 0, 0, 0, 0, 0, 0};
    public string buf;
    public string sv;
    public ScoreHandler sh;
    public void Getter()
    {
      
        using (FileStream fstream = File.OpenRead("scrs.txt"))
        {
            
            byte[] array = new byte[fstream.Length];
           
            fstream.Read(array, 0, array.Length);
           
            string buf = System.Text.Encoding.Default.GetString(array);
            string[] subs = buf.Split(' ');
            for (int g = 0; g < 5; g++)
            {
                a[g] = Convert.ToInt32(subs[g]);
                
            }
            sv = a[0].ToString() + ' ' + a[1].ToString() + ' ' + a[2].ToString() + ' ' + a[3].ToString() + ' ' +
                 a[4].ToString() + ' ';
            sh.bugf = sv;
        }
       

    }

    public void Setter(int value)
    {
        a.Add(value);
        a.Sort();
        a.Remove(a[0]);
        sv = a[0].ToString() + ' ' + a[1].ToString() + ' ' + a[2].ToString() + ' ' + a[3].ToString() + ' ' +
                    a[4].ToString() + ' ';
        sh.bugf = sv;


        using (FileStream fstream = new FileStream("scrs.txt", FileMode.OpenOrCreate))
        {
            byte[] array = System.Text.Encoding.Default.GetBytes(sv);
            fstream.Write(array, 0, array.Length);
        }

        using (var fs = new FileStream("scrs.txt", FileMode.Open))
        {
            StreamWriter sr = new StreamWriter(fs);

            sr.WriteLine(sv);
        }
    }
}
