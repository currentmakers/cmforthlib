\
\ @file trng.fs
\ @brief TRNG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TRNG_DEF

  [ifdef] TRNG_TRNG_CR_DEF
    \
    \ @brief TRNG_CR register
    \ Address offset: 0x00
    \ Reset value: 0x0000FF00
    \
    $00 constant TRNG_DISABLE                   \ [0x00] Disable Bit DISABLE can be used for reading or setting the state of the TRNG core. The value read is always the one available at the rng core clock domain. When changing the value, the change is effective when the value read is the same as the one written.
    $06 constant TRNG_CLR_REVCLK_FLAG           \ [0x06] Reset reveal clock error flags when writing a '1' without resetting the whole TRNG. When writing a 1, the value remains until it is seen by RNG core clock domain after resynchronization. Then it is automatically reset.
    $07 constant TRNG_RST_HEALTH_FLAGS          \ [0x07] Reset Health error flags when writing a '1' without resetting the whole TRNG. When writing a 1, the value remains until it is seen by RNG core clock domain after resynchronization. Then it is automatically reset.
    $08 constant TRNG_CLKDIV                    \ [0x08 : 16] Sampling Clock Enable Divider. CLKDIV[15:0] control the sampling clock enable divider, dividing by a factor equal to CLKDIV[15:0] + 1, values being in the range of 1 to 65536.
  [then]


  [ifdef] TRNG_TRNG_SR_DEF
    \
    \ @brief TRNG_SR register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TRNG_TRNG_DISABLED             \ [0x00] TRNG is disabled.
    $01 constant TRNG_ALL_OSCS_DOWN             \ [0x01] All oscillators of the random source noise have been powered down. This can cause the rising of OEC3 flag.
    $02 constant TRNG_REVEAL_CLK_ERR            \ [0x02] The internal clock for the RNG core is not revealed.
    $03 constant TRNG_ENTROPY_ERR               \ [0x03] The error refers to a fault in the bit sequence detected by the Entropy Monitor. Failed test is given by REPET_ERROR, and ADAPT_ERROR, OSCS_REPET_ERROR and OSCS_ADAPT_ERROR status flags.
    $04 constant TRNG_VAL_READY                 \ [0x04] TRNG Value ready At least one 32-bit random value is available in the data FIFO. Note that application must ensure that a random is available in internal FIFO before starting a read otherwise a bus error will be generated.
    $05 constant TRNG_FIFO_FULL                 \ [0x05] Indicates whether random data FIFO is full.
    $14 constant TRNG_SRC_HEALTH_DONE           \ [0x14] First run of noise source health test is completed
    $15 constant TRNG_REPET_ERROR               \ [0x15] Noise source Repetition health test error
    $16 constant TRNG_ADAPT_ERROR               \ [0x16] Noise source Adaptive 1024 health test error
    $17 constant TRNG_OSCS_HEALTH_DONE          \ [0x17] First run of source health tests of individual oscillators composing the noise source are completed.Reserved
    $18 constant TRNG_OSCS_REPET_ERROR          \ [0x18] Logical OR of repetition health test errors of individual oscillators composing the noise source.
    $19 constant TRNG_OSCS_ADAPT_ERROR          \ [0x19] Logical OR of adaptive health test errors of individual oscillators composing the noise source.
  [then]


  [ifdef] TRNG_TRNG_VAL_DEF
    \
    \ @brief TRNG_VAL register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TRNG_RND_VAL                   \ [0x00 : 32] RND_VAL is a 32-bit Random Value. This is the output of the internal four-word FIFO. Note that application must ensure that a random is available in FIFO by ready VAL_READY flag before starting a read otherwise a null value will be returned.
  [then]


  [ifdef] TRNG_TRNG_OSCS_CR_DEF
    \
    \ @brief TRNG_OSCS_CR register
    \ Address offset: 0x30
    \ Reset value: 0x80000000
    \
    $01 constant TRNG_PWRD1                     \ [0x01 : 3] Power down of individual oscillators in triple-oscillator block number 1
    $04 constant TRNG_PWRD2                     \ [0x04 : 3] Power down of individual oscillators in triple-oscillator block number 2
    $07 constant TRNG_PWRD3                     \ [0x07 : 3] Power down of individual oscillators in triple-oscillator block number 3
    $1f constant TRNG_SYNC_OSCS                 \ [0x1f] When set, selection of resynchronized output of oscillators.
  [then]


  [ifdef] TRNG_TRNG_POSTP_CR_DEF
    \
    \ @brief TRNG_POSTP_CR register
    \ Address offset: 0x34
    \ Reset value: 0x00000F00
    \
    $00 constant TRNG_AES_RESET                 \ [0x00] Reset AES post processing. When writing a 1, the AES post processing is reinitialized, resulting in a new key and new state generation before 128-bit random words generation. The '1' written is frozen until it is seen by RNG core clock domain after resynchronization. Then it is automatically reset. It also reruns analog source health tests.
    $08 constant TRNG_NB_LOOP_AES               \ [0x08 : 4] NB_LOOP_AES is the number of 128-bit words got from the noise source that have to be processed by AES for generating a single 128-bit random word. By default, this value is set to 2 (128 bits generated before an AES processing). 0 value means 16 loops. A new AES processing is started only when the previous one is completed.
    $10 constant TRNG_NB_RND_REINIT             \ [0x10 : 16] Number of 128-bit random words generated before AES automatically resets. This number is in the range of 1 to 65535 words. Value 0x0000 means that AES is never reinitialized.
  [then]


  [ifdef] TRNG_TRNG_POSTP_SR_DEF
    \
    \ @brief TRNG_POSTP_SR register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $01 constant TRNG_AES_INIT                  \ [0x01] AES Post processing has been fully initialized (key and state) and is ready for generating 128-bit random words.
    $02 constant TRNG_AES_KEY_LD                \ [0x02] AES random key has been generated and loaded in AES key register.
    $03 constant TRNG_AES_BUSY                  \ [0x03] AES core is busy, generating a random value.
    $04 constant TRNG_AES_HEALTH_DONE           \ [0x04] AES-CMAC health test is completed
    $05 constant TRNG_AES_K12_ERROR             \ [0x05] Health test error on AES-CMAC sub-keys generation
    $06 constant TRNG_AES_DOUT_ERROR            \ [0x06] Health test error on AES-CMAC output generation
  [then]


  [ifdef] TRNG_TRNG_DEFKEY0_DEF
    \
    \ @brief TRNG_DEFKEY0 register
    \ Address offset: 0x40
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant TRNG_RNG_DEFKEY0               \ [0x00 : 32] Bits 31 to 0 of AES 128-bit Default Key.
  [then]


  [ifdef] TRNG_TRNG_DEFKEY1_DEF
    \
    \ @brief TRNG_DEFKEY1 register
    \ Address offset: 0x44
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant TRNG_RNG_DEFKEY1               \ [0x00 : 32] Bits 63 to 31 of AES 128-bit Default Key.
  [then]


  [ifdef] TRNG_TRNG_DEFKEY2_DEF
    \
    \ @brief TRNG_DEFKEY2 register
    \ Address offset: 0x48
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant TRNG_RNG_DEFKEY2               \ [0x00 : 32] Bits 95 to 64 of AES 128-bit Default Key.
  [then]


  [ifdef] TRNG_TRNG_DEFKEY3_DEF
    \
    \ @brief TRNG_DEFKEY3 register
    \ Address offset: 0x4C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant TRNG_RNG_DEFKEY3               \ [0x00 : 32] Bits 127 to 96 of AES 128-bit Default Key.
  [then]


  [ifdef] TRNG_TRNG_HEALTH_CR_DEF
    \
    \ @brief TRNG_HEALTH_CR register
    \ Address offset: 0x60
    \ Reset value: 0x02BB0033
    \
    $00 constant TRNG_REPET_CUTOFF              \ [0x00 : 8] Cutoff value of Repetition Test. The default value is set to 51. Caution: To be handled with care as any change can lead to misbehavior of TRNG.
    $10 constant TRNG_ADAP_CUTOFF               \ [0x10 : 10] Cutoff value of Adaptive Test. The default value is set to 699. Caution: To be handled with care as any change can lead to misbehavior of TRNG.
    $1c constant TRNG_ITER_ADAP                 \ [0x1c : 2] Number of iterations minus 1 of Adaptive test during initialization phase. Default value is set to 0 i.e. 1 iteration.
  [then]


  [ifdef] TRNG_TRNG_HEALTH_OSC1_CR_DEF
    \
    \ @brief TRNG_HEALTH_OSC1_CR register
    \ Address offset: 0x68
    \ Reset value: 0x03E300FB
    \
    $00 constant TRNG_REPET_CUTOFF_OSC1         \ [0x00 : 8] Cutoff value of Repetition Test. The default value is set to 51. Caution: To be handled with care as any change can lead to misbehavior of TRNG.
    $10 constant TRNG_ADAP_CUTOFF_OSC1          \ [0x10 : 10] Cutoff value of Adaptive Test. The default value is set to 699. Caution: To be handled with care as any change can lead to misbehavior of TRNG.
  [then]


  [ifdef] TRNG_TRNG_HEALTH_OSC2_CR_DEF
    \
    \ @brief TRNG_HEALTH_OSC2_CR register
    \ Address offset: 0x6C
    \ Reset value: 0x03E300FB
    \
    $00 constant TRNG_REPET_CUTOFF_OSC2         \ [0x00 : 8] Cutoff value of Repetition Test. The default value is set to 51. Caution: To be handled with care as any change can lead to misbehavior of TRNG.
    $10 constant TRNG_ADAP_CUTOFF_OSC2          \ [0x10 : 10] Cutoff value of Adaptive Test. The default value is set to 699. Caution: To be handled with care as any change can lead to misbehavior of TRNG.
  [then]


  [ifdef] TRNG_TRNG_HEALTH_OSC3_CR_DEF
    \
    \ @brief TRNG_HEALTH_OSC3_CR register
    \ Address offset: 0x70
    \ Reset value: 0x03E300FB
    \
    $00 constant TRNG_REPET_CUTOFF_OSC3         \ [0x00 : 8] Cutoff value of Repetition Test. The default value is set to 51. Caution: To be handled with care as any change can lead to misbehavior of TRNG.
    $10 constant TRNG_ADAP_CUTOFF_OSC3          \ [0x10 : 10] Cutoff value of Adaptive Test. The default value is set to 699. Caution: To be handled with care as any change can lead to misbehavior of TRNG.
  [then]


  [ifdef] TRNG_TRNG_HEALTH_OSC1_SR_DEF
    \
    \ @brief TRNG_HEALTH_OSC1_SR register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant TRNG_TO1_REPET_ERROR           \ [0x00] Repetition error flag of first oscillator of first triple-oscillator cell.
    $01 constant TRNG_TO1_ADAPT_ERROR           \ [0x01] Adaptive error flag of first oscillator of first triple-oscillator cell.
    $02 constant TRNG_TO2_REPET_ERROR           \ [0x02] Repetition error flag of first oscillator of second triple-oscillator cell.
    $03 constant TRNG_TO2_ADAPT_ERROR           \ [0x03] Adaptive error flag of first oscillator of second triple-oscillator cell.
    $04 constant TRNG_TO3_REPET_ERROR           \ [0x04] Repetition error flag of first oscillator of third triple-oscillator cell.
    $05 constant TRNG_TO3_ADAPT_ERROR           \ [0x05] Adaptive error flag of first oscillator of third triple-oscillator cell.
  [then]


  [ifdef] TRNG_TRNG_HEALTH_OSC2_SR_DEF
    \
    \ @brief TRNG_HEALTH_OSC2_SR register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant TRNG_TO1_REPET_ERROR           \ [0x00] Repetition error flag of first oscillator of first triple-oscillator cell.
    $01 constant TRNG_TO1_ADAPT_ERROR           \ [0x01] Adaptive error flag of first oscillator of first triple-oscillator cell.
    $02 constant TRNG_TO2_REPET_ERROR           \ [0x02] Repetition error flag of first oscillator of second triple-oscillator cell.
    $03 constant TRNG_TO2_ADAPT_ERROR           \ [0x03] Adaptive error flag of first oscillator of second triple-oscillator cell.
    $04 constant TRNG_TO3_REPET_ERROR           \ [0x04] Repetition error flag of first oscillator of third triple-oscillator cell.
    $05 constant TRNG_TO3_ADAPT_ERROR           \ [0x05] Adaptive error flag of first oscillator of third triple-oscillator cell.
  [then]


  [ifdef] TRNG_TRNG_HEALTH_OSC3_SR_DEF
    \
    \ @brief TRNG_HEALTH_OSC3_SR register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant TRNG_TO1_REPET_ERROR           \ [0x00] Repetition error flag of third oscillator of first triple-oscillator cell.
    $01 constant TRNG_TO1_ADAPT_ERROR           \ [0x01] Adaptive error flag of first oscillator of first triple-oscillator cell.
    $02 constant TRNG_TO2_REPET_ERROR           \ [0x02] Repetition error flag of first oscillator of second triple-oscillator cell.
    $03 constant TRNG_TO2_ADAPT_ERROR           \ [0x03] Adaptive error flag of first oscillator of second triple-oscillator cell.
    $04 constant TRNG_TO3_REPET_ERROR           \ [0x04] Repetition error flag of first oscillator of third triple-oscillator cell.
    $05 constant TRNG_TO3_ADAPT_ERROR           \ [0x05] Adaptive error flag of first oscillator of third triple-oscillator cell.
  [then]


  [ifdef] TRNG_TRNG_IRQ_CR_DEF
    \
    \ @brief TRNG_IRQ_CR register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant TRNG_EN_FF_FULL_IRQ            \ [0x00] Enable the interrupt when the output fifo is full of new random.
    $08 constant TRNG_EN_ERROR_IRQ              \ [0x08] Enable the interrupt when an error is reported by the health tests.
  [then]


  [ifdef] TRNG_TRNG_IRQ_SR_DEF
    \
    \ @brief TRNG_IRQ_SR register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant TRNG_FF_FULL_IRQ               \ [0x00] Set to 1 when the output fifo is full of new random. Flag is cleared by writing a 1.
    $08 constant TRNG_ERROR_IRQ                 \ [0x08] Set to 1 when an error is reported by the health tests. Flag is cleared by writing a 1.
  [then]

  \
  \ @brief TRNG
  \
  $00 constant TRNG_TRNG_CR             \ TRNG_CR register
  $04 constant TRNG_TRNG_SR             \ TRNG_SR register
  $08 constant TRNG_TRNG_VAL            \ TRNG_VAL register
  $30 constant TRNG_TRNG_OSCS_CR        \ TRNG_OSCS_CR register
  $34 constant TRNG_TRNG_POSTP_CR       \ TRNG_POSTP_CR register
  $38 constant TRNG_TRNG_POSTP_SR       \ TRNG_POSTP_SR register
  $40 constant TRNG_TRNG_DEFKEY0        \ TRNG_DEFKEY0 register
  $44 constant TRNG_TRNG_DEFKEY1        \ TRNG_DEFKEY1 register
  $48 constant TRNG_TRNG_DEFKEY2        \ TRNG_DEFKEY2 register
  $4C constant TRNG_TRNG_DEFKEY3        \ TRNG_DEFKEY3 register
  $60 constant TRNG_TRNG_HEALTH_CR      \ TRNG_HEALTH_CR register
  $68 constant TRNG_TRNG_HEALTH_OSC1_CR \ TRNG_HEALTH_OSC1_CR register
  $6C constant TRNG_TRNG_HEALTH_OSC2_CR \ TRNG_HEALTH_OSC2_CR register
  $70 constant TRNG_TRNG_HEALTH_OSC3_CR \ TRNG_HEALTH_OSC3_CR register
  $74 constant TRNG_TRNG_HEALTH_OSC1_SR \ TRNG_HEALTH_OSC1_SR register
  $78 constant TRNG_TRNG_HEALTH_OSC2_SR \ TRNG_HEALTH_OSC2_SR register
  $7C constant TRNG_TRNG_HEALTH_OSC3_SR \ TRNG_HEALTH_OSC3_SR register
  $80 constant TRNG_TRNG_IRQ_CR         \ TRNG_IRQ_CR register
  $84 constant TRNG_TRNG_IRQ_SR         \ TRNG_IRQ_SR register

: TRNG_DEF ; [then]
