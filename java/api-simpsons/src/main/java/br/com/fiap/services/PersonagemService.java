package br.com.fiap.services;

import br.com.fiap.api.Personagem;
import com.google.gson.Gson;
import org.apache.http.HttpEntity;
import org.apache.http.client.methods.CloseableHttpResponse;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.CloseableHttpClient;
import org.apache.http.impl.client.HttpClientBuilder;
import org.apache.http.util.EntityUtils;

import java.io.IOException;

public class PersonagemService {

    public static Personagem getPersonagem(String p) throws IOException {

        Personagem personagem = null;

        HttpGet request = new HttpGet("https://thesimpsonsapi.com/api/characters/" + p);

        CloseableHttpClient httpClient = HttpClientBuilder.create().disableRedirectHandling().build();
        CloseableHttpResponse response = httpClient.execute(request);
        HttpEntity entity = response.getEntity();
        if(response.getStatusLine().getStatusCode() != 200){
            return null;//se o status nao for 200(ok) retorna null de cara ja
        }
        if(entity != null){
            String result = EntityUtils.toString(entity);
            Gson gson = new Gson();
            personagem = gson.fromJson(result, Personagem.class);
        }
        return  personagem;
    }
}
