package com.alvalabs.lookup.client;

import com.alvalabs.lookup.dto.*;
import org.springframework.stereotype.Component;
import org.springframework.web.client.HttpClientErrorException;
import org.springframework.web.client.RestTemplate;

@Component
public class CreditDataClient {

    private final RestTemplate restTemplate;

    public CreditDataClient(RestTemplate restTemplate) {
        this.restTemplate = restTemplate;
    }

    public PersonalDetails getPersonalDetails(String ssn) {
        return getOrNull(
                "https://coding-test-api.alvalabs.io/api/credit-data/personal-details/{ssn}",
                PersonalDetails.class,
                ssn
        );
    }

    public DebtDetails getDebtDetails(String ssn) {
        return getOrNull(
                "https://coding-test-api.alvalabs.io/api/credit-data/debt/{ssn}",
                DebtDetails.class,
                ssn
        );
    }

    public AssessedIncome getAssessedIncome(String ssn) {
        return getOrNull(
                "https://coding-test-api.alvalabs.io/api/credit-data/assessed-income/{ssn}",
                AssessedIncome.class,
                ssn
        );
    }

    private <T> T getOrNull(String url, Class<T> type, String ssn) {
        try {
            return restTemplate.getForObject(url, type, ssn);
        } catch (HttpClientErrorException.NotFound ex) {
            return null;
        }
    }
}