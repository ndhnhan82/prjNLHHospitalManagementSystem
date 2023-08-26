CREATE TABLE [dbo].[AdmissionRecords] (
    [AdmissionRecordID] NVARCHAR (30) NOT NULL,
    [PatientID]         NVARCHAR (15) NOT NULL,
    [DoctorID]          NCHAR (4)     NOT NULL,
    [BedNumber]         NVARCHAR (3)  NOT NULL,
    [SurgeryScheduled]  BIT           NOT NULL,
    [AdmitDate]         DATETIME      NOT NULL,
    [SurgeryDate]       DATETIME      NULL,
    [DischargeDate]     DATETIME      NULL,
    CONSTRAINT [PK__Admissio__83587E2DCEC05625] PRIMARY KEY CLUSTERED ([AdmissionRecordID] ASC),
    CONSTRAINT [FK__Admission__BedNu__5EBF139D] FOREIGN KEY ([BedNumber]) REFERENCES [dbo].[Beds] ([BedNumber]),
    CONSTRAINT [FK__Admission__Patie__5DCAEF64] FOREIGN KEY ([PatientID]) REFERENCES [dbo].[Patients] ([HealthNumber]),
    FOREIGN KEY ([DoctorID]) REFERENCES [dbo].[Doctors] ([DoctorID])
);

