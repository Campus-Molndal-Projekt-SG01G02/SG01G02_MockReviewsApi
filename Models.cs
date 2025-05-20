using System;
using System.Collections.Generic;

namespace SG01G02_MockReviewsApi.Models
{
    public class Review
    {
        public required string Id { get; set; }
        public required int ProductId { get; set; }
        public required string CustomerName { get; set; }
        public required string Content { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public required string Status { get; set; }

        // Parameterless constructor for serialization
        public Review() { }
    }

    public class ReviewResponse
    {
        public required List<Review> Reviews { get; set; }
        public required ReviewStats Stats { get; set; }

        // Parameterless constructor for serialization
        public ReviewResponse() { }

        // Constructor with required parameters
        public ReviewResponse(List<Review> reviews, ReviewStats stats)
        {
            Reviews = reviews;
            Stats = stats;
        }
    }

    public class ReviewStats
    {
        public required int ProductId { get; set; }
        public double AverageRating { get; set; }
        public int ReviewCount { get; set; }

        // Parameterless constructor for serialization
        public ReviewStats() { }
    }
}