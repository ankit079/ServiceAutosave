/****** Script for Finding all childs for a given parent with relevant program details ******/

USE [Autosave]
GO

DECLARE @ParentID int,
		@ParentName NVARCHAR(50),
		@SiteFL NVARCHAR(50);

SET @SiteFL = 'W2000090%';

SET @ParentID = (SELECT RM_Areas.AreaId FROM RM_Areas
WHERE RM_Areas.Description LIKE @SiteFL);

SET @ParentName = (SELECT RM_Areas.Name FROM RM_Areas
WHERE RM_Areas.Description LIKE @SiteFL);

SELECT rev.AncNumber AS LatestRevision,	   
	   rev.StoreDate,
	   cl.Name AS AssetName,
	   us.Name AS UserName,
	   --rev.VersionId,
	   --rev.RevisionId,
	   a.Location AS Functional_Location,
	   fp.FullPath AS AutoSave_FullPath,
	   --a.AreaId,
	   a.[Description] AS Asset_Description,
	   a.Name AS ProgramName,
	   a.ParentAreaId

FROM RM_Revisions AS rev

INNER JOIN (SELECT ar.AreaId, max(StoreDate) as maxdate
			FROM RM_Revisions as rv
			INNER JOIN RM_Versions as vr ON vr.VersionId = rv.VersionId
			INNER JOIN RM_Areas as ar ON ar.AreaId = vr.AreaId
			INNER JOIN RM_FullPaths as fpa ON fpa.AreaId = ar.AreaId
			GROUP BY ar.AreaId) tm on  rev.StoreDate = maxdate

INNER JOIN RM_Versions as ver
	ON rev.VersionId = ver.VersionId

INNER JOIN RM_Areas as a
	ON a.AreaId = ver.AreaId
	
INNER JOIN RM_FullPaths as fp
	ON a.AreaId = fp.AreaId

INNER JOIN AS_Users as us
	ON rev.UserId = us.UserId

INNER JOIN HS_Clients as cl
	ON rev.ClientId = cl.ClientId

WHERE a.[ParentAreaId] = @ParentID;

--Display site name in the message

DECLARE @PrintMessage nvarchar(100);  
SET @PrintMessage = @ParentName + N' Site Information '  
    + RTRIM(CAST(GETDATE() AS nvarchar(30)))  
    + N'.';  
PRINT @PrintMessage;  
GO
