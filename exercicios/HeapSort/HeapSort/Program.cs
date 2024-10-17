﻿using HeapSort;


var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
var expected = new int[] { 1, 20, 49, 57, 73, 99, 133 };
var sortFunction = new HeapSort.HeapSort();

var sortedArray = HeapSort.HeapSort.SortArray(array, array.Length);

Assert.IsNotNull(sortedArray);
CollectionAssert.AreEqual(sortedArray, expected);