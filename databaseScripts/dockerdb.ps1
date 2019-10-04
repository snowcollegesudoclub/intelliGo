docker run --name intelligoDb \
    -p 5432:5432 \
    -e POSTGRES_USER=intelligo \
    -e POSTGRES_PASSWORD=sudoclub \
    -e POSTGRES_DB=intelligodb \
    postgres