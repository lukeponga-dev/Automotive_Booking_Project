SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([User_Id], [Name], [Telephone], [email]) VALUES (1, N'Luke', 73783737, N'luke@gmail.com')
INSERT INTO [dbo].[Users] ([User_Id], [Name], [Telephone], [email]) VALUES (2, N'Jack', 211535414, N'jack@gmail.com')
INSERT INTO [dbo].[Users] ([User_Id], [Name], [Telephone], [email]) VALUES (3, N'John', 2110345677, N'Email@email.com')
INSERT INTO [dbo].[Users] ([User_Id], [Name], [Telephone], [email]) VALUES (4, N'Smith', 2113456888, N'Smith@outlook.com')
SET IDENTITY_INSERT [dbo].[Users] OFF


SET IDENTITY_INSERT [dbo].[BookingReason] ON
INSERT INTO [dbo].[BookingReason] ([BookingReason_Id], [reason]) VALUES (1, N'Oil Change')
INSERT INTO [dbo].[BookingReason] ([BookingReason_Id], [reason]) VALUES (2, N'New Tyres')
INSERT INTO [dbo].[BookingReason] ([BookingReason_Id], [reason]) VALUES (3, N'Service')
INSERT INTO [dbo].[BookingReason] ([BookingReason_Id], [reason]) VALUES (4, N'Wof')
SET IDENTITY_INSERT [dbo].[BookingReason] OFF

SET IDENTITY_INSERT [dbo].[Staff] ON
INSERT INTO [dbo].[Staff] ([Id], [Name]) VALUES (1, N'Brad')
INSERT INTO [dbo].[Staff] ([Id], [Name]) VALUES (2, N'Tonk')
INSERT INTO [dbo].[Staff] ([Id], [Name]) VALUES (3, N'Will')
INSERT INTO [dbo].[Staff] ([Id], [Name]) VALUES (4, N'Richard')
SET IDENTITY_INSERT [dbo].[Staff] OFF

SET IDENTITY_INSERT [dbo].[bookings] ON
INSERT INTO [dbo].[bookings] ([Id], [User_Id], [UsersUser_Id], [BookingReason_Id], [BookingReason_Id1], [staff_Id], [StaffId]) VALUES (1, 1, NULL, 1, NULL, 2, NULL)
INSERT INTO [dbo].[bookings] ([Id], [User_Id], [UsersUser_Id], [BookingReason_Id], [BookingReason_Id1], [staff_Id], [StaffId]) VALUES (2, 2, NULL, 3, NULL, 3, NULL)
INSERT INTO [dbo].[bookings] ([Id], [User_Id], [UsersUser_Id], [BookingReason_Id], [BookingReason_Id1], [staff_Id], [StaffId]) VALUES (3, 3, NULL, 4, NULL, 4, NULL)
INSERT INTO [dbo].[bookings] ([Id], [User_Id], [UsersUser_Id], [BookingReason_Id], [BookingReason_Id1], [staff_Id], [StaffId]) VALUES (4, 4, NULL, 2, NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[bookings] OFF
