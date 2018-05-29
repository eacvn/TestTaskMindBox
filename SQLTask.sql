SELECT p.Name, c.Name FROM 
	Product p LEFT OUTER JOIN ProductCategory rpc ON rpc.ProductId = p.Id
	LEFT OUTER JOIN Category c ON c.Id = rpc.CategoryId
