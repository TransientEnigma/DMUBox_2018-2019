CREATE TABLE [dbo].[tblStudent] (
    [StudentNo]   INT          NOT NULL IDENTITY,
    [Title Mr,Miss,Mrs,Ms,Dr]       VARCHAR (50) NOT NULL,
    [Forname]     VARCHAR (50) NOT NULL,
    [FamilyName]  VARCHAR (50) NOT NULL,
    [HallNo]      INT          NOT NULL,
    [ApartmentNo] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([StudentNo] ASC),
    CONSTRAINT [CK_tblStudent_ApartmentNo_Range] CHECK ([ApartmentNo]>=(0) AND [ApartmentNo]<=(10000)),
    CONSTRAINT [CK_tblStudent_HallNo_Range] CHECK ([HallNo]>=(0) AND [HallNo]<=(10000)),
    CONSTRAINT [CK_tblStudent_StudentNo_NotBlank] CHECK (len([StudentNo])>=(1)),
    CONSTRAINT [CK_tblStudent_Title_NotBlank] CHECK (len([Title Mr,Miss,Mrs,Ms,Dr])>=(1)),
    CONSTRAINT [CK_tblStudent_Forname_NotBlank] CHECK (len([Forname])>=(1)),
    CONSTRAINT [CK_tblStudent_FamilyName_NotBlank] CHECK (len([FamilyName])>=(1)),
    CONSTRAINT [CK_tblStudent_HallNo_NotBlank] CHECK (len([HallNo])>=(1)),
    CONSTRAINT [CK_tblStudent_ApartmentNo_NotBlank] CHECK (len([ApartmentNo])>=(1)),
    CONSTRAINT [CK_tblStudent_Forname_AllLetters] CHECK(NOT ([Forname] like '%[0-9]%')),
    CONSTRAINT [CK_tblStudent_FamilyName_AllLetters] CHECK(NOT ([Forname] like '%[0-9]%')),
    CONSTRAINT [CK_tblStudent_Title_Type] CHECK ([Title Mr,Miss,Mrs,Ms,Dr]='dr' OR [Title Mr,Miss,Mrs,Ms,Dr]='ms' OR [Title Mr,Miss,Mrs,Ms,Dr]='miss' OR [Title Mr,Miss,Mrs,Ms,Dr]='mrs' OR [Title Mr,Miss,Mrs,Ms,Dr]='mr'), 
    CONSTRAINT [CK_tblStudent_StudentNo_Range] CHECK ([StudentNo]>=(0) AND [StudentNo]<=(1000000))
);

