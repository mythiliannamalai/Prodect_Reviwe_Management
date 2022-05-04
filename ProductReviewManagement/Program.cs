﻿using System;
using System.Data;

namespace ProductReviewManagementlinq
{
    class Program
    {
        private static List<ProductReview> productReviewList;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Product Review Management");
            ProductReviewManagement productReview = new ProductReviewManagement();
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
              new ProductReview() { ProductID = 1, UserID = 1, Rating = 1, Review = "good", IsLike = true },
              new ProductReview() { ProductID = 2, UserID = 2, Rating = 1, Review = "good", IsLike = true },
              new ProductReview() { ProductID = 3, UserID = 3, Rating = 1, Review = "good", IsLike = true },
              new ProductReview() { ProductID = 4, UserID = 4, Rating = 4, Review = "good", IsLike = true },
              new ProductReview() { ProductID = 5, UserID = 5, Rating = 2, Review = "nice", IsLike = false },
              new ProductReview() { ProductID = 6, UserID = 6, Rating = 2, Review = "bad", IsLike = false },
              new ProductReview() { ProductID = 7, UserID = 7, Rating = 2, Review = "bad", IsLike = false },
              new ProductReview() { ProductID = 8, UserID = 8, Rating = 2, Review = "good", IsLike = true },
              new ProductReview() { ProductID = 9, UserID = 9, Rating = 3, Review = "bad", IsLike = false },
              new ProductReview() { ProductID = 10, UserID = 10, Rating = 3, Review = "bad", IsLike = false },
              new ProductReview() { ProductID = 11, UserID = 11, Rating = 1, Review = "good", IsLike = true },
              new ProductReview() { ProductID = 12, UserID = 12, Rating = 5, Review = "good", IsLike = true },
              new ProductReview() { ProductID = 13, UserID = 13, Rating = 3, Review = "good", IsLike = true },
              new ProductReview() { ProductID = 14, UserID = 14, Rating = 2, Review = "very bad", IsLike = false },
              new ProductReview() { ProductID = 15, UserID = 15, Rating = 2, Review = "bad", IsLike = false },
              new ProductReview() { ProductID = 16, UserID = 16, Rating = 2, Review = "bad", IsLike = false },
              new ProductReview() { ProductID = 17, UserID = 17, Rating = 2, Review = "bad", IsLike = false },
              new ProductReview() { ProductID = 18, UserID = 18, Rating = 2, Review = "average", IsLike = true },
              new ProductReview() { ProductID = 19, UserID = 19, Rating = 3, Review = "bad", IsLike = false },
              new ProductReview() { ProductID = 20, UserID = 20, Rating = 3, Review = "bad", IsLike = false },
              new ProductReview() { ProductID = 21, UserID = 21, Rating = 2, Review = "bad", IsLike = false },
              new ProductReview() { ProductID = 22, UserID = 22, Rating = 2, Review = "bad", IsLike = false },
              new ProductReview() { ProductID = 23, UserID = 23, Rating = 2, Review = "good", IsLike = true },
              new ProductReview() { ProductID = 24, UserID = 24, Rating = 4, Review = "average", IsLike = true },
              new ProductReview() { ProductID = 25, UserID = 25, Rating = 2, Review = "average", IsLike = true }             
            };
            Console.WriteLine("Add Product Review");
            productReview.AddProductReviewManagement();
        }
    }
}