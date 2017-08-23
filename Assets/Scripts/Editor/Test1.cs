using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class NewEditModeTest {

   

    [Test]
	public void EsMultiploDe4_1984() {
        Bisiesto bi = new Bisiesto();
        //bool b;
        //b = bi.EsBisiesto(1986);
        Assert.That(bi.EsBisiesto(1984));
        

    }
    [Test]
    public void EsMultiploDe4_2012()
    {
        Bisiesto bi = new Bisiesto();
        //bool b;
        //b = bi.EsBisiesto(1986);
        Assert.That(bi.EsBisiesto(2012));
    }

    [Test]
    public void EsMultiploDe4_2011()
    {
        Bisiesto bi = new Bisiesto();
        //bool b;
        //b = bi.EsBisiesto(1986);
        Assert.That(bi.EsBisiesto(2011));
    }

    [Test]
    public void EsMultiploDe100_1800()
    {
        Bisiesto bi = new Bisiesto();
        //bool b;
        //b = bi.EsBisiesto(1986);
        Assert.That(bi.EsBisiesto(1800));
    }

    [Test]
    public void EsMultiploDe100_1900()
    {
        Bisiesto bi = new Bisiesto();
        //bool b;
        //b = bi.EsBisiesto(1986);
        Assert.That(bi.EsBisiesto(1900));
    }
  
    [Test]
    public void EsMultiploDe400_2000()
    {
        Bisiesto bi = new Bisiesto();
        //bool b;
        //b = bi.EsBisiesto(1986);
        Assert.That(bi.EsBisiesto(2000));
    }

    [Test]
    public void EsMultiploDe400_1600()
    {
        Bisiesto bi = new Bisiesto();
        //bool b;
        //b = bi.EsBisiesto(1986);
        Assert.That(bi.EsBisiesto(1600));
    }


}
