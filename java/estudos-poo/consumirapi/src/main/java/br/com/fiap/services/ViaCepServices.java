package br.com.fiap.services;

import br.com.fiap.api.Endereco;
import com.google.gson.Gson;
import org.apache.http.HttpEntity;
import org.apache.http.client.methods.CloseableHttpResponse;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.CloseableHttpClient;
import org.apache.http.impl.client.HttpClientBuilder;
import org.apache.http.util.EntityUtils;

import java.io.IOException;

public class ViaCepServices  {
    public Endereco getEndereco(String cep) throws IOException {
        Endereco endereco = null;

        //request Htg
        HttpGet request =  new HttpGet("https://viacep.com.br/ws/"+cep+"/json/");

        //client CHC                     HCB                        drh
        CloseableHttpClient HttpClient = HttpClientBuilder.create().disableRedirectHandling().build();

        //response CHR
        CloseableHttpResponse response = HttpClient.execute(request);

        //entity
        HttpEntity entity = response.getEntity();

        if(entity != null){
            //                  Entiu
            String resultado = EntityUtils.toString(entity);

            //Instanciar Gson
            Gson gson = new Gson();

            endereco = gson.fromJson(resultado, Endereco.class);
        }


        return endereco;
    }
}
