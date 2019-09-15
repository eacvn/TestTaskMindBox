SELECT a.Subject, t.Name FROM 
	Articles a LEFT OUTER JOIN Article_Tag at ON at.ArticleId = a.Id
	LEFT OUTER JOIN Tags t ON t.Id = at.TagId
