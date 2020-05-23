# WebAPI

To Test, mount ProductDB.bak and change connection string from the settings.

On swagger, generate first the token using auth/token endpoint.
Generated token will be used in authorization from swagger.
input >> "bearer (generatedToken)" to use the endpoints.

example.
bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJVc2VySWQiLCJqdGkiOiI2OGUxOGQwMi00MjY0LTRkMzQtOGQ0Zi0xYTIzNmJlMDg1MDQiLCJleHAiOjE1OTAxOTY1NzMsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6NTYwMTkiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjU2MDE5In0.Uo8UpXPPsB4t55uTTCuCSheJyUld7DAKZKIANboxy-E

token will expire in 2 hours.
