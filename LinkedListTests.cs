using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsDataStructures
{
    [TestClass]
    public class LinkedListTests
    {
        // �������� �����
        Node userNode0, userNode1, userNode2, userNode3, userNode4, userNode5, userNode6, userNode7, userNode8, userNode9, userNode10, userNode11, userNode12, userNode13, userNode14, userNode15;

        // �������� ���������� ������ � 10 ����������
        LinkedList userList;

        // �������� ���������� ������ � 1 ���������
        LinkedList userListOne;

        // �������� ������� ���������� ������
        LinkedList userListEmpty;

        [TestInitialize]
        public void TestInitialize()
        {
            // ������������� ����� ����������
            userNode0 = new Node(42);

            userNode1 = new Node(13);
            userNode2 = new Node(7);
            userNode3 = new Node(24);
            userNode4 = new Node(0);
            userNode5 = new Node(0);
            userNode6 = new Node(12);
            userNode7 = new Node(2);
            userNode8 = new Node(7);
            userNode9 = new Node(7);
            userNode10 = new Node(7);

            userNode11 = new Node(12);
            userNode12 = new Node(21);
            userNode13 = new Node(37);
            userNode14 = new Node(84);
            userNode15 = new Node(11);

            // ���������� ����� � ������ � 10 ����������
            userList = new LinkedList();
            userList.AddInTail(userNode1);
            userList.AddInTail(userNode2);
            userList.AddInTail(userNode3);
            userList.AddInTail(userNode4);
            userList.AddInTail(userNode5);
            userList.AddInTail(userNode6);
            userList.AddInTail(userNode7);
            userList.AddInTail(userNode8);
            userList.AddInTail(userNode9);
            userList.AddInTail(userNode10);

            // ���������� ���� � ������ �� 1 ��������
            userListOne = new LinkedList();
            userListOne.AddInTail(userNode0);

            // �������� ������� ������
            userListEmpty = new LinkedList();
        }
        [TestMethod]
        public void CountElementsInList()
        {
            // arrange
            int userListExpected = 10;
            int userListExpectedOne = 1;
            int userListExpectedEmpty = 0;

            // act
            int actual = userList.Count();
            int actualOne = userListOne.Count();
            int actualEmpty = userListEmpty.Count();

            // assert
            Assert.AreEqual(userListExpected, actual);
            Assert.AreEqual(userListExpectedOne, actualOne);
            Assert.AreEqual(userListExpectedEmpty, actualEmpty);
        }

        [TestMethod]
        public void ClearElementsInList()
        {
            // arrange
            int userListExpected = 0;
            int userListExpectedOne = 0;
            int userListExpectedEmpty = 0;

            // act
            userList.Clear();
            userListOne.Clear();
            userListEmpty.Clear();

            int actual = userList.Count();
            int actualOne = userListOne.Count();
            int actualEmpty = userListEmpty.Count();

            // assert
            Assert.AreEqual(userListExpected, actual);
            Assert.AreEqual(userListExpectedOne, actualOne);
            Assert.AreEqual(userListExpectedEmpty, actualEmpty);
        }

        [TestMethod]
        public void RemoveElementInListByValue()
        {
            // arrange

            // ������ � 10 ����������
            int userListExpected = 10;
            int userListExpectedV = 9;

            // ������ � 1 ���������
            int userListExpectedOne = 1;
            int userListExpectedOneV = 0;

            // ������ ������
            int userListExpectedEmpty = 0;

            // act + assert

            // ������ � 10 ����������
            userList.Remove(30); //�������� ��� � ������
            int actual = userList.Count();
            Assert.AreEqual(userListExpected, actual);

            userList.Remove(7); //�������� ���� � ������
            actual = userList.Count();
            Assert.AreEqual(userListExpectedV, actual);

            // ������ � 1 ���������
            userListOne.Remove(2); //�������� ��� � ������
            int actualOne = userListOne.Count();
            Assert.AreEqual(userListExpectedOne, actualOne);

            userListOne.Remove(42); //�������� ���� � ������
            actualOne = userListOne.Count();
            Assert.AreEqual(userListExpectedOneV, actualOne);

            // ������ ������
            userListEmpty.Remove(1);
            int actualEmpty = userListEmpty.Count();
            Assert.AreEqual(userListExpectedEmpty, actualEmpty);
        }

        [TestMethod]
        public void RemoveAllElementsInListByValue()
        {
            // arrange

            // ������ � 10 ����������
            int userListExpected = 10;
            int userListExpectedV = 6;

            // ������ � 1 ���������
            int userListExpectedOne = 1;
            int userListExpectedOneV = 0;

            // ������ ������
            int userListExpectedEmpty = 0;

            // act + assert

            // ������ � 10 ����������
            userList.RemoveAll(30); //�������� ��� � ������
            int actual = userList.Count();
            Assert.AreEqual(userListExpected, actual);

            userList.RemoveAll(7); //�������� ���� � ������
            actual = userList.Count();
            Assert.AreEqual(userListExpectedV, actual);

            // ������ � 1 ���������
            userListOne.RemoveAll(2); //�������� ��� � ������
            int actualOne = userListOne.Count();
            Assert.AreEqual(userListExpectedOne, actualOne);

            userListOne.RemoveAll(42); //�������� ���� � ������
            actualOne = userListOne.Count();
            Assert.AreEqual(userListExpectedOneV, actualOne);

            // ������ ������
            userListEmpty.RemoveAll(1);
            int actualEmpty = userListEmpty.Count();
            Assert.AreEqual(userListExpectedEmpty, actualEmpty);
        }

        [TestMethod]
        public void FindAllElementsInListByValue()
        {
            // arrange

            // ������ � 10 ����������
            int userListExpected = 0;
            int userListExpectedV = 4;

            // ������ � 1 ���������
            int userListExpectedOne = 0;
            int userListExpectedOneV = 1;

            // ������ ������
            int userListExpectedEmpty = 0;

            // act + assert

            // ������ � 10 ����������
            int actual = userList.FindAll(30).Count; //�������� ��� � ������
            Assert.AreEqual(userListExpected, actual);

            actual = userList.FindAll(7).Count; //�������� ���� � ������
            Assert.AreEqual(userListExpectedV, actual);

            // ������ � 1 ���������
            int actualOne = userListOne.FindAll(2).Count; //�������� ��� � ������
            Assert.AreEqual(userListExpectedOne, actualOne);

            actualOne = userListOne.FindAll(42).Count; //�������� ���� � ������
            Assert.AreEqual(userListExpectedOneV, actualOne);

            // ������ ������
            int actualEmpty = userListEmpty.FindAll(1).Count;
            Assert.AreEqual(userListExpectedEmpty, actualEmpty);
        }

        [TestMethod]
        public void InsertAfterNodeByValue()
        {
            // arrange

            // ������ � 10 ����������
            int userListExpected = 10;
            int userListExpectedV = 11;
            int userListExpectedVH = 12;
            int userListExpectedVT = 13;

            // ������ � 1 ���������
            int userListExpectedOne = 1;
            int userListExpectedOneV = 2;

            // ������ ������
            int userListExpectedEmpty = 0;
            int userListExpectedEmptyV = 1;

            // act + assert

            // ������ � 10 ����������
            userList.InsertAfter(userNode0, userNode11);  //�������� ��� � ������
            int actual = userList.Count();
            Assert.AreEqual(userListExpected, actual);

            userList.InsertAfter(userNode6, userNode11); //�������� ���� � ������ (������� � ��������)
            actual = userList.Count();
            Assert.AreEqual(userListExpectedV, actual);

            userList.InsertAfter(userNode1, userNode12); //�������� ���� � ������ (������� � ������)
            actual = userList.Count();
            Assert.AreEqual(userListExpectedVH, actual);

            userList.InsertAfter(userNode10, userNode13); //�������� ���� � ������ (������� � �����)
            actual = userList.Count();
            Assert.AreEqual(userListExpectedVT, actual);

            // ������ � 1 ���������
            userListOne.InsertAfter(userNode3, userNode14); //�������� ��� � ������
            int actualOne = userListOne.Count();
            Assert.AreEqual(userListExpectedOne, actualOne);

            userListOne.InsertAfter(userNode0, userNode14); //�������� ���� � ������
            actualOne = userListOne.Count();
            Assert.AreEqual(userListExpectedOneV, actualOne);

            // ������ ������
            userListEmpty.InsertAfter(userNode10, userNode15);
            int actualEmpty = userListEmpty.Count();
            Assert.AreEqual(userListExpectedEmpty, actualEmpty);

            userListEmpty.InsertAfter(null, userNode15); // ��� ������ null ������� � ������
            actualEmpty = userListEmpty.Count();
            Assert.AreEqual(userListExpectedEmptyV, actualEmpty);
        }
    }
}

