using GenericsHomework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GenericsHomeworkTests;

[TestClass]
public class NodeTests
{
    [TestMethod]
    public void NodeTypeString_Are_Equal()
    {
        Node<string> newNode = new("one");
        Assert.AreEqual<string>("one", newNode.Value);

        Node<string> newNode2 = new("two", newNode);
        Assert.AreEqual<string>("two", newNode2.Value);
    }

    [TestMethod]
    public void NodeIsLast_True()
    {
        Node<string> newNode = new("one");
        Assert.IsTrue(newNode.Equals(newNode.Last));

        Node<string> newNode2 = new("two", newNode);
        Assert.IsTrue(newNode2.Equals(newNode2.Last));
    }

    [TestMethod]
    public void NodeExists_True()
    {
        Node<string> newNode = new("23");
        Assert.IsTrue(newNode.Exists("23"));
    }

    [TestMethod]
    public void NodeExists_False()
    {
        Node<string> newNode = new("11");
        Assert.IsFalse(newNode.Exists("12"));
    }

    [TestMethod]
    public void NodeExists_Null_True()
    {
        string empty = null!;
        Node<string> newNode = new("one");
        newNode.Append("two");
        newNode.Append(empty);
        newNode.Append("three");

        Assert.IsTrue(newNode.Exists(null!));
    }

    [TestMethod]
    public void NodeAppend_DuplicateValue_throwsException()
    {
        _ = Assert.ThrowsException<ArgumentException>(() =>
        {
            Node<double> newNode = DoubleNodes();
            newNode.Append(13);
        });
    }


    [TestMethod]
    public void NodeClear_RemovesAllNodesNotLast()
    {
        Node<double> newNode = DoubleNodes();
        Assert.IsTrue(newNode.Exists(13));
        Assert.IsTrue(newNode.Exists(88));
        Assert.IsTrue(newNode.Exists(99));
        Assert.IsTrue(newNode.Exists(100));
        Assert.IsTrue(newNode.Exists(108));

        newNode.Clear();
        Assert.IsTrue(newNode.Exists(13));
        Assert.IsFalse(newNode.Exists(88));
        Assert.IsFalse(newNode.Exists(99));
        Assert.IsFalse(newNode.Exists(100));
        Assert.IsFalse(newNode.Exists(108));
    }

    public static Node<double> DoubleNodes()
    {
        Node<double> newNode = new(13);
        newNode.Append(88);
        newNode.Append(99);
        newNode.Append(100);
        newNode.Append(108);
        return newNode;
    }
}