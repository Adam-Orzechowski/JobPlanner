﻿// <auto-generated />
using System;
using JobPlanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobPlanner.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250131185919_UserToLocation")]
    partial class UserToLocation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("ApplicationUserLocation", b =>
                {
                    b.Property<Guid>("LocationsId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UsersId")
                        .HasColumnType("TEXT");

                    b.HasKey("LocationsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("ApplicationUserLocation");
                });

            modelBuilder.Entity("JobPlanner.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Image")
                        .HasColumnType("BLOB");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "22d1a66c-ccd8-4c1e-8763-a896c287ea2c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ed8422eb-c86d-450b-aec4-18a9698a0747",
                            Email = "admin@localhost",
                            EmailConfirmed = true,
                            Image = new byte[] { 255, 216, 255, 224, 0, 16, 74, 70, 73, 70, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0, 255, 219, 0, 67, 0, 6, 4, 4, 4, 5, 4, 6, 5, 5, 6, 9, 6, 5, 6, 9, 11, 8, 6, 6, 8, 11, 12, 10, 10, 11, 10, 10, 12, 16, 12, 12, 12, 12, 12, 12, 16, 12, 14, 15, 16, 15, 14, 12, 19, 19, 20, 20, 19, 19, 28, 27, 27, 27, 28, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 255, 219, 0, 67, 1, 7, 7, 7, 13, 12, 13, 24, 16, 16, 24, 26, 21, 17, 21, 26, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 255, 192, 0, 17, 8, 0, 150, 0, 150, 3, 1, 17, 0, 2, 17, 1, 3, 17, 1, 255, 196, 0, 28, 0, 1, 0, 2, 3, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 6, 2, 5, 7, 3, 4, 8, 255, 196, 0, 55, 16, 0, 1, 4, 1, 2, 4, 4, 3, 5, 7, 5, 0, 0, 0, 0, 0, 1, 0, 2, 3, 17, 4, 5, 33, 18, 49, 65, 81, 6, 19, 34, 97, 50, 145, 161, 20, 113, 129, 177, 193, 7, 66, 67, 98, 114, 209, 241, 21, 35, 51, 82, 130, 255, 196, 0, 26, 1, 1, 0, 3, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 4, 5, 2, 3, 6, 255, 196, 0, 37, 17, 1, 0, 2, 2, 2, 3, 0, 3, 0, 2, 3, 0, 0, 0, 0, 0, 0, 1, 2, 3, 17, 4, 49, 18, 33, 65, 34, 81, 97, 5, 50, 19, 66, 129, 255, 218, 0, 12, 3, 1, 0, 2, 17, 3, 17, 0, 63, 0, 252, 254, 190, 137, 224, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 154, 40, 141, 161, 8, 17, 34, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 12, 153, 28, 143, 32, 49, 165, 196, 242, 0, 18, 162, 109, 16, 230, 102, 33, 148, 145, 74, 199, 112, 188, 22, 158, 199, 111, 205, 68, 90, 37, 17, 104, 248, 143, 48, 242, 34, 192, 189, 186, 11, 236, 166, 33, 49, 86, 36, 138, 21, 218, 138, 105, 58, 66, 148, 192, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 131, 125, 225, 22, 201, 62, 127, 217, 131, 168, 26, 45, 246, 55, 205, 81, 230, 234, 43, 181, 46, 102, 162, 54, 184, 228, 248, 67, 3, 50, 114, 252, 135, 185, 199, 187, 118, 250, 44, 234, 114, 109, 88, 212, 51, 171, 202, 181, 99, 211, 204, 126, 207, 180, 54, 144, 110, 71, 111, 124, 246, 62, 203, 210, 121, 185, 29, 79, 59, 33, 153, 224, 93, 10, 88, 139, 34, 99, 160, 147, 155, 100, 105, 191, 194, 138, 138, 243, 114, 68, 247, 178, 188, 220, 144, 165, 107, 154, 4, 218, 100, 181, 241, 199, 255, 0, 117, 165, 199, 228, 198, 70, 150, 14, 68, 93, 169, 86, 150, 132, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 25, 53, 142, 113, 166, 139, 73, 157, 34, 103, 75, 79, 130, 113, 94, 53, 1, 32, 6, 184, 119, 247, 43, 51, 157, 125, 198, 153, 220, 203, 238, 52, 232, 81, 53, 220, 86, 86, 91, 42, 94, 212, 7, 53, 46, 94, 82, 87, 68, 117, 10, 215, 138, 162, 6, 6, 201, 91, 182, 239, 241, 86, 56, 211, 249, 45, 113, 231, 219, 156, 61, 188, 47, 115, 123, 18, 22, 236, 116, 220, 172, 250, 98, 165, 34, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 13, 134, 154, 198, 151, 182, 133, 185, 196, 10, 62, 234, 190, 105, 85, 205, 50, 233, 90, 22, 159, 30, 38, 47, 19, 90, 60, 199, 139, 229, 208, 172, 76, 151, 242, 150, 70, 91, 238, 91, 22, 206, 200, 189, 82, 184, 52, 13, 201, 38, 128, 92, 60, 117, 183, 199, 147, 226, 157, 6, 7, 112, 203, 148, 208, 70, 214, 1, 35, 232, 189, 105, 130, 246, 234, 30, 149, 227, 100, 158, 161, 235, 6, 167, 167, 102, 52, 156, 76, 152, 229, 246, 107, 129, 63, 37, 197, 169, 106, 247, 8, 182, 59, 87, 184, 107, 181, 136, 163, 159, 6, 98, 242, 26, 0, 250, 133, 56, 167, 86, 135, 166, 41, 212, 185, 150, 96, 172, 151, 215, 35, 78, 31, 113, 22, 190, 131, 28, 254, 45, 220, 115, 186, 188, 87, 110, 196, 4, 4, 4, 4, 4, 4, 4, 4, 4, 22, 13, 39, 195, 145, 230, 225, 9, 61, 101, 242, 14, 46, 54, 145, 77, 222, 168, 54, 183, 229, 221, 80, 205, 202, 154, 219, 74, 57, 121, 19, 91, 105, 147, 244, 233, 48, 242, 34, 133, 190, 190, 39, 15, 46, 70, 236, 10, 230, 50, 197, 235, 50, 227, 254, 79, 40, 219, 162, 233, 237, 119, 148, 208, 238, 128, 5, 149, 44, 171, 207, 182, 57, 248, 44, 145, 156, 79, 143, 207, 175, 225, 237, 71, 240, 41, 19, 49, 41, 165, 148, 173, 104, 186, 46, 22, 55, 65, 141, 165, 223, 197, 147, 127, 160, 160, 22, 142, 15, 126, 252, 218, 56, 125, 255, 0, 221, 191, 240, 239, 135, 49, 204, 17, 229, 201, 24, 129, 238, 0, 136, 219, 209, 85, 205, 150, 102, 117, 189, 170, 231, 207, 59, 212, 52, 94, 61, 202, 205, 195, 212, 27, 134, 195, 195, 142, 248, 248, 154, 238, 246, 104, 171, 92, 28, 85, 152, 220, 247, 11, 92, 28, 117, 181, 119, 245, 78, 117, 222, 230, 235, 107, 230, 181, 90, 112, 132, 72, 128, 128, 128, 128, 128, 128, 128, 128, 128, 130, 213, 225, 121, 188, 252, 51, 136, 79, 192, 227, 196, 208, 106, 218, 119, 165, 151, 204, 175, 141, 188, 153, 188, 186, 234, 219, 111, 178, 177, 226, 102, 40, 28, 28, 46, 137, 193, 209, 109, 64, 5, 74, 150, 157, 170, 68, 206, 219, 189, 62, 110, 40, 152, 225, 184, 33, 121, 76, 43, 222, 61, 182, 22, 9, 8, 243, 120, 100, 98, 65, 43, 129, 145, 161, 213, 221, 54, 234, 182, 151, 188, 77, 130, 38, 1, 92, 45, 31, 11, 66, 34, 119, 42, 183, 237, 23, 18, 60, 157, 50, 44, 166, 15, 94, 51, 141, 159, 229, 112, 175, 204, 43, 156, 28, 154, 190, 191, 107, 191, 227, 239, 53, 182, 191, 110, 106, 182, 155, 98, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 13, 150, 131, 33, 25, 237, 143, 136, 180, 74, 8, 182, 154, 32, 141, 193, 10, 183, 42, 55, 93, 254, 149, 249, 49, 248, 237, 111, 201, 151, 32, 97, 58, 57, 156, 36, 111, 238, 191, 225, 63, 250, 31, 217, 100, 214, 34, 109, 233, 155, 17, 27, 244, 216, 232, 211, 189, 144, 181, 174, 220, 109, 186, 243, 201, 219, 199, 45, 91, 232, 164, 99, 136, 163, 107, 205, 94, 97, 148, 188, 144, 171, 231, 201, 51, 49, 156, 81, 186, 54, 208, 221, 210, 241, 80, 249, 41, 143, 235, 170, 199, 237, 90, 241, 55, 138, 112, 31, 166, 79, 167, 188, 199, 54, 91, 154, 224, 225, 21, 150, 13, 182, 54, 66, 187, 199, 227, 219, 202, 45, 241, 115, 141, 199, 183, 148, 91, 227, 157, 45, 150, 208, 128, 128, 128, 128, 128, 128, 128, 128, 128, 128, 131, 237, 209, 65, 58, 166, 56, 28, 236, 159, 144, 43, 199, 145, 63, 132, 188, 121, 19, 248, 74, 245, 46, 55, 159, 134, 246, 15, 136, 182, 219, 247, 133, 135, 91, 106, 219, 100, 196, 234, 95, 46, 143, 168, 70, 15, 3, 156, 3, 219, 181, 95, 85, 235, 155, 28, 246, 239, 37, 86, 60, 73, 7, 157, 185, 178, 55, 217, 86, 85, 188, 62, 172, 214, 229, 74, 193, 30, 59, 152, 194, 119, 123, 223, 100, 87, 106, 21, 205, 35, 95, 92, 83, 81, 219, 79, 171, 229, 235, 24, 248, 254, 91, 113, 224, 115, 29, 232, 54, 247, 147, 190, 220, 200, 94, 184, 235, 73, 238, 101, 237, 142, 180, 153, 237, 207, 53, 108, 169, 102, 203, 153, 210, 70, 198, 60, 158, 2, 24, 109, 160, 10, 216, 124, 150, 214, 10, 68, 86, 53, 45, 156, 52, 136, 136, 212, 190, 5, 238, 247, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 110, 60, 45, 27, 95, 169, 217, 171, 107, 28, 90, 61, 213, 78, 108, 207, 130, 175, 46, 117, 85, 235, 26, 139, 1, 234, 22, 36, 178, 172, 209, 107, 154, 108, 208, 78, 115, 49, 46, 206, 239, 104, 252, 213, 220, 25, 162, 99, 198, 203, 56, 178, 68, 250, 150, 90, 87, 136, 227, 18, 51, 204, 125, 86, 207, 191, 209, 50, 241, 167, 226, 50, 96, 149, 183, 11, 80, 198, 200, 143, 137, 178, 11, 232, 21, 43, 86, 99, 181, 43, 82, 97, 167, 241, 88, 6, 33, 89, 37, 128, 2, 224, 198, 141, 141, 123, 175, 126, 63, 125, 61, 184, 253, 244, 230, 178, 59, 137, 228, 221, 239, 207, 191, 186, 221, 172, 122, 110, 86, 61, 49, 93, 58, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 219, 211, 30, 121, 96, 153, 147, 68, 238, 25, 35, 32, 180, 174, 111, 88, 180, 106, 92, 90, 177, 104, 212, 186, 6, 131, 170, 69, 168, 99, 241, 138, 108, 141, 218, 88, 251, 59, 251, 30, 139, 11, 145, 134, 113, 219, 76, 140, 248, 166, 147, 166, 221, 208, 178, 70, 112, 184, 90, 240, 218, 188, 79, 181, 87, 196, 126, 30, 224, 226, 201, 197, 244, 1, 187, 219, 64, 126, 54, 180, 56, 220, 159, 150, 94, 193, 200, 249, 42, 204, 90, 134, 161, 138, 242, 216, 230, 116, 110, 7, 112, 15, 80, 180, 103, 21, 45, 239, 75, 211, 142, 182, 132, 79, 169, 231, 78, 73, 150, 87, 58, 246, 221, 43, 134, 181, 234, 19, 92, 53, 135, 202, 189, 94, 162, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 32, 63, 229, 64, 158, 94, 232, 62, 189, 51, 81, 200, 211, 178, 134, 68, 36, 26, 161, 35, 47, 103, 55, 178, 243, 205, 138, 50, 87, 82, 243, 203, 142, 47, 26, 151, 71, 211, 53, 60, 124, 220, 118, 207, 3, 173, 142, 231, 220, 30, 160, 251, 172, 28, 152, 166, 147, 169, 98, 229, 199, 53, 157, 75, 199, 94, 204, 56, 248, 143, 120, 104, 118, 199, 99, 178, 235, 13, 60, 173, 16, 156, 85, 220, 185, 172, 211, 62, 105, 93, 43, 235, 137, 198, 205, 108, 23, 208, 86, 186, 141, 67, 114, 149, 138, 198, 144, 35, 113, 0, 129, 96, 223, 81, 123, 11, 41, 180, 204, 177, 82, 232, 68, 8, 8, 8, 8, 8, 8, 8, 8, 108, 68, 10, 4, 128, 78, 213, 100, 242, 164, 54, 95, 249, 65, 38, 247, 176, 1, 231, 219, 159, 178, 15, 167, 78, 212, 242, 244, 252, 143, 59, 25, 213, 127, 28, 103, 118, 184, 118, 33, 121, 229, 195, 91, 198, 165, 231, 147, 20, 94, 53, 43, 33, 147, 35, 196, 152, 206, 251, 59, 140, 126, 80, 30, 124, 55, 100, 95, 47, 188, 21, 159, 21, 142, 61, 189, 168, 204, 70, 25, 246, 212, 105, 186, 35, 167, 151, 35, 26, 123, 142, 97, 25, 49, 216, 228, 224, 225, 186, 179, 151, 147, 227, 17, 49, 210, 198, 78, 70, 181, 48, 213, 77, 11, 225, 146, 72, 101, 105, 108, 177, 184, 181, 195, 177, 7, 117, 110, 182, 220, 110, 58, 89, 139, 110, 55, 12, 167, 120, 115, 201, 28, 32, 30, 18, 90, 219, 171, 225, 163, 205, 68, 66, 43, 15, 37, 211, 177, 1, 1, 1, 1, 1, 9, 17, 7, 62, 74, 3, 221, 72, 40, 1, 87, 191, 47, 209, 72, 158, 93, 62, 106, 4, 41, 78, 153, 22, 250, 120, 182, 0, 154, 13, 187, 42, 28, 255, 0, 27, 63, 14, 103, 229, 225, 106, 240, 125, 149, 255, 0, 243, 189, 177, 74, 218, 176, 230, 151, 114, 35, 234, 188, 57, 56, 226, 212, 157, 252, 120, 242, 113, 197, 169, 59, 248, 232, 158, 68, 50, 102, 22, 249, 94, 178, 206, 41, 38, 3, 102, 213, 16, 223, 197, 97, 196, 206, 187, 99, 110, 98, 59, 83, 252, 101, 129, 31, 28, 26, 155, 90, 91, 30, 67, 157, 20, 228, 11, 167, 51, 225, 53, 182, 229, 171, 79, 131, 146, 117, 53, 105, 112, 242, 79, 186, 170, 203, 69, 125, 39, 135, 106, 55, 221, 16, 132, 72, 128, 128, 128, 129, 186, 33, 32, 111, 202, 250, 154, 80, 29, 16, 57, 95, 77, 144, 57, 215, 79, 126, 232, 2, 200, 35, 160, 221, 4, 209, 189, 135, 49, 181, 164, 3, 44, 22, 154, 7, 175, 171, 145, 164, 36, 4, 138, 118, 221, 69, 82, 147, 76, 154, 226, 199, 49, 225, 252, 47, 96, 226, 99, 153, 204, 56, 27, 23, 239, 107, 157, 109, 206, 183, 183, 85, 208, 38, 116, 250, 76, 57, 114, 184, 58, 105, 162, 14, 121, 228, 110, 183, 219, 221, 124, 254, 106, 234, 243, 17, 251, 97, 102, 141, 94, 97, 240, 107, 152, 236, 155, 195, 121, 177, 150, 217, 108, 77, 201, 143, 216, 142, 100, 124, 151, 167, 26, 218, 201, 18, 244, 193, 109, 100, 135, 54, 244, 240, 155, 190, 45, 168, 244, 247, 181, 189, 61, 182, 231, 182, 69, 210, 73, 212, 18, 231, 19, 64, 0, 110, 151, 58, 210, 53, 16, 193, 116, 232, 64, 64, 64, 64, 251, 148, 33, 39, 234, 121, 132, 16, 107, 159, 79, 116, 1, 243, 64, 219, 168, 180, 37, 52, 64, 220, 118, 82, 109, 54, 61, 54, 75, 133, 114, 237, 236, 129, 200, 53, 197, 131, 132, 130, 7, 185, 29, 84, 74, 15, 134, 183, 14, 177, 203, 181, 254, 170, 83, 47, 88, 49, 178, 102, 138, 71, 197, 9, 116, 113, 144, 101, 152, 2, 67, 7, 243, 17, 200, 46, 45, 120, 137, 141, 203, 155, 90, 34, 99, 114, 232, 94, 25, 202, 251, 71, 133, 99, 119, 57, 161, 47, 129, 206, 235, 241, 109, 244, 114, 197, 229, 211, 199, 36, 255, 0, 88, 252, 154, 107, 44, 255, 0, 91, 140, 156, 81, 36, 2, 17, 176, 150, 39, 227, 147, 253, 109, 219, 234, 23, 133, 45, 169, 218, 189, 109, 169, 255, 0, 215, 33, 116, 110, 99, 221, 17, 4, 185, 150, 210, 42, 136, 225, 231, 178, 250, 56, 157, 198, 223, 67, 19, 184, 219, 29, 247, 234, 137, 71, 231, 217, 72, 34, 68, 4, 4, 19, 215, 111, 170, 132, 32, 109, 184, 59, 160, 157, 186, 20, 16, 130, 122, 17, 221, 4, 129, 191, 21, 91, 123, 20, 68, 162, 253, 53, 125, 119, 111, 234, 137, 250, 202, 199, 169, 193, 131, 132, 250, 64, 38, 232, 247, 8, 132, 7, 142, 34, 224, 56, 93, 251, 161, 188, 190, 168, 157, 124, 123, 226, 234, 25, 88, 176, 228, 69, 12, 207, 137, 153, 12, 224, 149, 141, 170, 120, 236, 235, 246, 92, 94, 149, 180, 196, 204, 116, 226, 248, 226, 211, 19, 63, 22, 239, 2, 206, 231, 233, 217, 216, 132, 0, 88, 230, 60, 1, 217, 205, 171, 219, 250, 86, 111, 62, 191, 148, 75, 59, 157, 31, 148, 74, 224, 239, 86, 39, 152, 57, 176, 181, 255, 0, 35, 107, 61, 159, 245, 205, 188, 103, 167, 12, 45, 122, 87, 129, 80, 101, 84, 204, 35, 111, 139, 103, 129, 248, 173, 190, 30, 79, 42, 127, 97, 179, 195, 201, 229, 77, 125, 134, 136, 26, 32, 139, 4, 110, 15, 80, 65, 218, 149, 165, 182, 82, 19, 197, 197, 196, 92, 231, 15, 91, 143, 82, 121, 239, 213, 69, 81, 30, 216, 46, 157, 8, 8, 8, 6, 169, 66, 18, 57, 237, 177, 232, 16, 63, 52, 16, 128, 130, 118, 234, 47, 109, 190, 245, 36, 179, 96, 121, 115, 104, 144, 234, 244, 87, 63, 101, 18, 137, 97, 181, 27, 27, 244, 40, 150, 111, 47, 245, 88, 109, 216, 248, 106, 238, 182, 170, 81, 26, 68, 105, 137, 13, 23, 189, 186, 249, 244, 247, 82, 149, 163, 246, 124, 93, 254, 161, 146, 26, 211, 193, 228, 255, 0, 186, 235, 219, 226, 28, 59, 124, 213, 15, 242, 63, 235, 10, 28, 255, 0, 245, 133, 250, 10, 251, 52, 161, 223, 5, 58, 207, 178, 201, 100, 207, 112, 172, 120, 245, 184, 46, 209, 241, 29, 144, 240, 204, 214, 27, 199, 97, 4, 151, 138, 1, 226, 219, 117, 208, 238, 174, 240, 102, 222, 115, 174, 190, 174, 240, 102, 222, 115, 174, 156, 255, 0, 106, 2, 183, 28, 207, 117, 176, 216, 66, 148, 136, 8, 8, 8, 63, 255, 217 },
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST",
                            NormalizedUserName = "ADMIN@LOCALHOST",
                            PasswordHash = "AQAAAAIAAYagAAAAEEb+SpYOga6Foz0WtoFZuX8Cr2Kk5+kogO/kFoW5kSqr3lPY6bIDxbiIVv7pstDc8w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d6755e72-eee6-4a44-a6bf-4d8e3bc6d2e4",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost"
                        });
                });

            modelBuilder.Entity("JobPlanner.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Image")
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "5e174d1e-2b9f-48fe-9561-1149894920f5",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "22d1a66c-ccd8-4c1e-8763-a896c287ea2c",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "22d1a66c-ccd8-4c1e-8763-a896c287ea2c",
                            RoleId = "5e174d1e-2b9f-48fe-9561-1149894920f5"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ApplicationUserLocation", b =>
                {
                    b.HasOne("JobPlanner.Models.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("JobPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("JobPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("JobPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
