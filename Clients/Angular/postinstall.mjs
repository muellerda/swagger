import http from 'http';
import fs from 'fs';
import util from 'util';
import request from 'request';

const mkdir = util.promisify(fs.mkdir);
const access = util.promisify(fs.access);

async function main() {
 await createBinFolder();
 await getSwaggerCodeGen();
}

async function createBinFolder() {
  try {
    console.log('Bin folder is being created...')
    await mkdir('bin');
    console.log('Bin folder created.')
  }
  catch (err)
  {
    if (err.code && err.code === 'EEXIST') {
      console.log('Bin folder already exists')
    } else {
      console.log(err);
    }
  }
}

function getSwaggerCodeGen() {
  return new Promise(async (resolve, reject) => {
    const swaggerCodeGenDestination = 'bin/swagger-codegen-cli.jar';
    const swaggerCodeGenFileServerUrl = 'http://central.maven.org/maven2/io/swagger/swagger-codegen-cli/2.3.1/swagger-codegen-cli-2.3.1.jar';

    try {
      await access(swaggerCodeGenDestination, fs.constants.F_OK)
      console.log('Swagger codegen already exists.')
      resolve();
      return;
    } catch (err) {
      if (err && err.code == 'ENOENT') {
        console.log('Swagger codegen does not exist.')
      } else {
        console.log(err);
      }
    }

    console.log('Swagger codegen is being downloaded...')
    let swaggerCodeGenStream =
    request(swaggerCodeGenFileServerUrl)
      .pipe(fs.createWriteStream(swaggerCodeGenDestination));
    swaggerCodeGenStream.on('finish', () => {
      console.log('Swagger codegen downloaded.')
      resolve();
    });
    swaggerCodeGenStream.on('error', (err) => {
      console.log(err);
      reject();
    });
  });
}

main();
