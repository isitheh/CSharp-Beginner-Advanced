using System;

/*
 * DiscountCalculator Class: Class
 * This class demonstrates a constraint to a class.
 * Signified by "where TClass : SomeClass" - Means that
 * TClass can be SomeClass or any subclasses of SomeClass.
 */
public class DiscountCalculator<TProduct> where TProduct : Product
{
	public float CalculateDiscount(TProduct product)
    {
        return product.Price;
    }
}