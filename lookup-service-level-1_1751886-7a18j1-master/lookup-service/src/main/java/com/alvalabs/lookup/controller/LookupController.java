package com.alvalabs.lookup.controller;

import com.alvalabs.lookup.dto.CreditData;
import com.alvalabs.lookup.service.LookupService;
import org.springframework.web.bind.annotation.*;

@RestController
public class LookupController {

    private final LookupService lookupService;

    public LookupController(LookupService lookupService) {
        this.lookupService = lookupService;
    }

    @GetMapping("/ping")
    public void ping() {}

    @GetMapping("/credit-data/{ssn}")
    public CreditData getCreditData(@PathVariable String ssn) {
        return lookupService.getCreditData(ssn);
    }
}