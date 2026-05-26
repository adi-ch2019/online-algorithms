# Navigate to the sql directory
cd sql

# Start SQLite with your database
sqlite3 practice.db

# Once in SQLite prompt, run your queries:
.read 01_join.sql
.read 02_join_groupby.sql
# etc.

# Or run a single query directly:
sqlite3 practice.db "SELECT * FROM authors;"
