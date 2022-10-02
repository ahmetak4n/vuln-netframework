[![build](https://github.com/ahmetak4n/vuln-netframework/actions/workflows/build.yml/badge.svg)](https://github.com/ahmetak4n/vuln-netframework/actions/workflows/build.yml) [![semgrep-rules](https://github.com/ahmetak4n/vuln-netframework/actions/workflows/semgrep-rules.yml/badge.svg)](https://github.com/ahmetak4n/vuln-netframework/actions/workflows/semgrep-rules.yml) [![Bugs](https://sonarcloud.io/api/project_badges/measure?project=ahmetak4n_vuln-netframework&metric=bugs)](https://sonarcloud.io/dashboard?id=ahmetak4n_vuln-netframework) [![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=ahmetak4n_vuln-netframework&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=ahmetak4n_vuln-netframework)

# vuln-netframework
vuln-netframework is a .net-framework 4.7 project that include worst coding practices about common vulnerabilities like Insecure Deserialization, Os Command Injection, SQL Injection, etc.

# setup
## pre-request
- .net framework 4.7
- database for SQL Injection arttacks (optional)
	- change [connection string](https://github.com/ahmetak4n/vuln-netframework/blob/master/vuln-netframework/Web.config#L26) via your db values
	- create a table that name `USER`
	- `USER` table must include two cloumns these names `NAME` and `ROLE`

# security-topics
- Injection
  - OS Command Injection
  - SQL Injection
- Request Forgery Attacks
  - Server Side Request Forgery
- General Web Vulnerabilities
  - Insecure Deserialization (Friday the 13th JSON)
  - Regular Expression DOS

# devsecops
- All vulnerabilities can be detected via [semgrep-rules](https://github.com/returntocorp/semgrep-rules)

# contribution
- If you want to support, just send PR :)

**Note:** Please pay attantion project structure before creating PR
