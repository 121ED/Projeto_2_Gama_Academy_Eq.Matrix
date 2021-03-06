package projeto.spring.controller;

import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import projeto.spring.model.Conta;
import projeto.spring.repository.ContaRepo;

@RestController
@RequestMapping("/contas")
@CrossOrigin("*")
public class ContaController {
    
    @Autowired
    private ContaRepo repo;

    // *********** Buscar todas as contas **************
    @GetMapping() 
    public List<Conta> obterTodos() {
        return (List<Conta>) repo.findAll(); 
    }
    
    // *********** Buscar em contas pelo número da conta ***********
    @GetMapping("/{numConta}") 
    public ResponseEntity<Conta> obterConta(@PathVariable long numConta) {
        Conta contaEncontrada = repo.findById(numConta).orElse(null);
        
        if (contaEncontrada != null) {
            return ResponseEntity.ok(contaEncontrada);
        } else {
            return ResponseEntity.notFound().build();
        }
    }

    // *********** Cadastro de contas ************
    @PostMapping("/nova") // Adicionar novos
    public ResponseEntity<Conta> novaConta(@RequestBody Conta conta) { 
        if (conta.getNumConta() != 0) {
            return ResponseEntity.status(400).build(); 
        }
        Conta novaConta = repo.save(conta);
        return ResponseEntity.status(201).body(novaConta); 
    }

    // *********** Deletar conta ************
    @DeleteMapping("/delete/{codInt}")
    public ResponseEntity<Void> apagarConta(@PathVariable long numConta) {
        Conta contaEncontrada = repo.findById(numConta).orElse(null);

        if (contaEncontrada == null) {
            return ResponseEntity.status(404).build();
        }

        repo.deleteById(numConta);
        return ResponseEntity.ok().build();
    }
}
