```sh
docker build -t justfortesting .
docker run -e "ASPNETCORE_ENVIRONMENT=Development" -it --rm -p 8100:80 --name justfortesting justfortesting
```