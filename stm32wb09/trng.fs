\
\ @file trng.fs
\ @brief TRNG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TRNG_CR register
\ Address offset: 0x00
\ Reset value: 0x0000FF00
\

$00000001 constant TRNG_TRNG_CR_DISABLE                             \ Disable Bit DISABLE can be used for reading or setting the state of the TRNG core. The value read is always the one available at the rng core clock domain. When changing the value, the change is effective when the value read is the same as the one written.
$00000040 constant TRNG_TRNG_CR_CLR_REVCLK_FLAG                     \ Reset reveal clock error flags when writing a '1' without resetting the whole TRNG. When writing a 1, the value remains until it is seen by RNG core clock domain after resynchronization. Then it is automatically reset.
$00000080 constant TRNG_TRNG_CR_RST_HEALTH_FLAGS                    \ Reset Health error flags when writing a '1' without resetting the whole TRNG. When writing a 1, the value remains until it is seen by RNG core clock domain after resynchronization. Then it is automatically reset.
$00ffff00 constant TRNG_TRNG_CR_CLKDIV                              \ Sampling Clock Enable Divider. CLKDIV[15:0] control the sampling clock enable divider, dividing by a factor equal to CLKDIV[15:0] + 1, values being in the range of 1 to 65536.


\
\ @brief TRNG_SR register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TRNG_TRNG_SR_TRNG_DISABLED                       \ TRNG is disabled.
$00000002 constant TRNG_TRNG_SR_ALL_OSCS_DOWN                       \ All oscillators of the random source noise have been powered down. This can cause the rising of OEC3 flag.
$00000004 constant TRNG_TRNG_SR_REVEAL_CLK_ERR                      \ The internal clock for the RNG core is not revealed.
$00000008 constant TRNG_TRNG_SR_ENTROPY_ERR                         \ The error refers to a fault in the bit sequence detected by the Entropy Monitor. Failed test is given by REPET_ERROR, and ADAPT_ERROR, OSCS_REPET_ERROR and OSCS_ADAPT_ERROR status flags.
$00000010 constant TRNG_TRNG_SR_VAL_READY                           \ TRNG Value ready At least one 32-bit random value is available in the data FIFO. Note that application must ensure that a random is available in internal FIFO before starting a read otherwise a bus error will be generated.
$00000020 constant TRNG_TRNG_SR_FIFO_FULL                           \ Indicates whether random data FIFO is full.
$00100000 constant TRNG_TRNG_SR_SRC_HEALTH_DONE                     \ First run of noise source health test is completed
$00200000 constant TRNG_TRNG_SR_REPET_ERROR                         \ Noise source Repetition health test error
$00400000 constant TRNG_TRNG_SR_ADAPT_ERROR                         \ Noise source Adaptive 1024 health test error
$00800000 constant TRNG_TRNG_SR_OSCS_HEALTH_DONE                    \ First run of source health tests of individual oscillators composing the noise source are completed.Reserved
$01000000 constant TRNG_TRNG_SR_OSCS_REPET_ERROR                    \ Logical OR of repetition health test errors of individual oscillators composing the noise source.
$02000000 constant TRNG_TRNG_SR_OSCS_ADAPT_ERROR                    \ Logical OR of adaptive health test errors of individual oscillators composing the noise source.


\
\ @brief TRNG_VAL register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant TRNG_TRNG_VAL_RND_VAL                            \ RND_VAL is a 32-bit Random Value. This is the output of the internal four-word FIFO. Note that application must ensure that a random is available in FIFO by ready VAL_READY flag before starting a read otherwise a null value will be returned.


\
\ @brief TRNG_OSCS_CR register
\ Address offset: 0x30
\ Reset value: 0x80000000
\

$0000000e constant TRNG_TRNG_OSCS_CR_PWRD1                          \ Power down of individual oscillators in triple-oscillator block number 1
$00000070 constant TRNG_TRNG_OSCS_CR_PWRD2                          \ Power down of individual oscillators in triple-oscillator block number 2
$00000380 constant TRNG_TRNG_OSCS_CR_PWRD3                          \ Power down of individual oscillators in triple-oscillator block number 3
$80000000 constant TRNG_TRNG_OSCS_CR_SYNC_OSCS                      \ When set, selection of resynchronized output of oscillators.


\
\ @brief TRNG_POSTP_CR register
\ Address offset: 0x34
\ Reset value: 0x00000F00
\

$00000001 constant TRNG_TRNG_POSTP_CR_AES_RESET                     \ Reset AES post processing. When writing a 1, the AES post processing is reinitialized, resulting in a new key and new state generation before 128-bit random words generation. The '1' written is frozen until it is seen by RNG core clock domain after resynchronization. Then it is automatically reset. It also reruns analog source health tests.
$00000f00 constant TRNG_TRNG_POSTP_CR_NB_LOOP_AES                   \ NB_LOOP_AES is the number of 128-bit words got from the noise source that have to be processed by AES for generating a single 128-bit random word. By default, this value is set to 2 (128 bits generated before an AES processing). 0 value means 16 loops. A new AES processing is started only when the previous one is completed.
$ffff0000 constant TRNG_TRNG_POSTP_CR_NB_RND_REINIT                 \ Number of 128-bit random words generated before AES automatically resets. This number is in the range of 1 to 65535 words. Value 0x0000 means that AES is never reinitialized.


\
\ @brief TRNG_POSTP_SR register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000002 constant TRNG_TRNG_POSTP_SR_AES_INIT                      \ AES Post processing has been fully initialized (key and state) and is ready for generating 128-bit random words.
$00000004 constant TRNG_TRNG_POSTP_SR_AES_KEY_LD                    \ AES random key has been generated and loaded in AES key register.
$00000008 constant TRNG_TRNG_POSTP_SR_AES_BUSY                      \ AES core is busy, generating a random value.
$00000010 constant TRNG_TRNG_POSTP_SR_AES_HEALTH_DONE               \ AES-CMAC health test is completed
$00000020 constant TRNG_TRNG_POSTP_SR_AES_K12_ERROR                 \ Health test error on AES-CMAC sub-keys generation
$00000040 constant TRNG_TRNG_POSTP_SR_AES_DOUT_ERROR                \ Health test error on AES-CMAC output generation


\
\ @brief TRNG_DEFKEY0 register
\ Address offset: 0x40
\ Reset value: 0xFFFFFFFF
\

$00000000 constant TRNG_TRNG_DEFKEY0_RNG_DEFKEY0                    \ Bits 31 to 0 of AES 128-bit Default Key.


\
\ @brief TRNG_DEFKEY1 register
\ Address offset: 0x44
\ Reset value: 0xFFFFFFFF
\

$00000000 constant TRNG_TRNG_DEFKEY1_RNG_DEFKEY1                    \ Bits 63 to 31 of AES 128-bit Default Key.


\
\ @brief TRNG_DEFKEY2 register
\ Address offset: 0x48
\ Reset value: 0xFFFFFFFF
\

$00000000 constant TRNG_TRNG_DEFKEY2_RNG_DEFKEY2                    \ Bits 95 to 64 of AES 128-bit Default Key.


\
\ @brief TRNG_DEFKEY3 register
\ Address offset: 0x4C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant TRNG_TRNG_DEFKEY3_RNG_DEFKEY3                    \ Bits 127 to 96 of AES 128-bit Default Key.


\
\ @brief TRNG_HEALTH_CR register
\ Address offset: 0x60
\ Reset value: 0x02BB0033
\

$000000ff constant TRNG_TRNG_HEALTH_CR_REPET_CUTOFF                 \ Cutoff value of Repetition Test. The default value is set to 51. Caution: To be handled with care as any change can lead to misbehavior of TRNG.
$03ff0000 constant TRNG_TRNG_HEALTH_CR_ADAP_CUTOFF                  \ Cutoff value of Adaptive Test. The default value is set to 699. Caution: To be handled with care as any change can lead to misbehavior of TRNG.
$30000000 constant TRNG_TRNG_HEALTH_CR_ITER_ADAP                    \ Number of iterations minus 1 of Adaptive test during initialization phase. Default value is set to 0 i.e. 1 iteration.


\
\ @brief TRNG_HEALTH_OSC1_CR register
\ Address offset: 0x68
\ Reset value: 0x03E300FB
\

$000000ff constant TRNG_TRNG_HEALTH_OSC1_CR_REPET_CUTOFF_OSC1       \ Cutoff value of Repetition Test. The default value is set to 51. Caution: To be handled with care as any change can lead to misbehavior of TRNG.
$03ff0000 constant TRNG_TRNG_HEALTH_OSC1_CR_ADAP_CUTOFF_OSC1        \ Cutoff value of Adaptive Test. The default value is set to 699. Caution: To be handled with care as any change can lead to misbehavior of TRNG.


\
\ @brief TRNG_HEALTH_OSC2_CR register
\ Address offset: 0x6C
\ Reset value: 0x03E300FB
\

$000000ff constant TRNG_TRNG_HEALTH_OSC2_CR_REPET_CUTOFF_OSC2       \ Cutoff value of Repetition Test. The default value is set to 51. Caution: To be handled with care as any change can lead to misbehavior of TRNG.
$03ff0000 constant TRNG_TRNG_HEALTH_OSC2_CR_ADAP_CUTOFF_OSC2        \ Cutoff value of Adaptive Test. The default value is set to 699. Caution: To be handled with care as any change can lead to misbehavior of TRNG.


\
\ @brief TRNG_HEALTH_OSC3_CR register
\ Address offset: 0x70
\ Reset value: 0x03E300FB
\

$000000ff constant TRNG_TRNG_HEALTH_OSC3_CR_REPET_CUTOFF_OSC3       \ Cutoff value of Repetition Test. The default value is set to 51. Caution: To be handled with care as any change can lead to misbehavior of TRNG.
$03ff0000 constant TRNG_TRNG_HEALTH_OSC3_CR_ADAP_CUTOFF_OSC3        \ Cutoff value of Adaptive Test. The default value is set to 699. Caution: To be handled with care as any change can lead to misbehavior of TRNG.


\
\ @brief TRNG_HEALTH_OSC1_SR register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant TRNG_TRNG_HEALTH_OSC1_SR_TO1_REPET_ERROR         \ Repetition error flag of first oscillator of first triple-oscillator cell.
$00000002 constant TRNG_TRNG_HEALTH_OSC1_SR_TO1_ADAPT_ERROR         \ Adaptive error flag of first oscillator of first triple-oscillator cell.
$00000004 constant TRNG_TRNG_HEALTH_OSC1_SR_TO2_REPET_ERROR         \ Repetition error flag of first oscillator of second triple-oscillator cell.
$00000008 constant TRNG_TRNG_HEALTH_OSC1_SR_TO2_ADAPT_ERROR         \ Adaptive error flag of first oscillator of second triple-oscillator cell.
$00000010 constant TRNG_TRNG_HEALTH_OSC1_SR_TO3_REPET_ERROR         \ Repetition error flag of first oscillator of third triple-oscillator cell.
$00000020 constant TRNG_TRNG_HEALTH_OSC1_SR_TO3_ADAPT_ERROR         \ Adaptive error flag of first oscillator of third triple-oscillator cell.


\
\ @brief TRNG_HEALTH_OSC2_SR register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000001 constant TRNG_TRNG_HEALTH_OSC2_SR_TO1_REPET_ERROR         \ Repetition error flag of first oscillator of first triple-oscillator cell.
$00000002 constant TRNG_TRNG_HEALTH_OSC2_SR_TO1_ADAPT_ERROR         \ Adaptive error flag of first oscillator of first triple-oscillator cell.
$00000004 constant TRNG_TRNG_HEALTH_OSC2_SR_TO2_REPET_ERROR         \ Repetition error flag of first oscillator of second triple-oscillator cell.
$00000008 constant TRNG_TRNG_HEALTH_OSC2_SR_TO2_ADAPT_ERROR         \ Adaptive error flag of first oscillator of second triple-oscillator cell.
$00000010 constant TRNG_TRNG_HEALTH_OSC2_SR_TO3_REPET_ERROR         \ Repetition error flag of first oscillator of third triple-oscillator cell.
$00000020 constant TRNG_TRNG_HEALTH_OSC2_SR_TO3_ADAPT_ERROR         \ Adaptive error flag of first oscillator of third triple-oscillator cell.


\
\ @brief TRNG_HEALTH_OSC3_SR register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000001 constant TRNG_TRNG_HEALTH_OSC3_SR_TO1_REPET_ERROR         \ Repetition error flag of third oscillator of first triple-oscillator cell.
$00000002 constant TRNG_TRNG_HEALTH_OSC3_SR_TO1_ADAPT_ERROR         \ Adaptive error flag of first oscillator of first triple-oscillator cell.
$00000004 constant TRNG_TRNG_HEALTH_OSC3_SR_TO2_REPET_ERROR         \ Repetition error flag of first oscillator of second triple-oscillator cell.
$00000008 constant TRNG_TRNG_HEALTH_OSC3_SR_TO2_ADAPT_ERROR         \ Adaptive error flag of first oscillator of second triple-oscillator cell.
$00000010 constant TRNG_TRNG_HEALTH_OSC3_SR_TO3_REPET_ERROR         \ Repetition error flag of first oscillator of third triple-oscillator cell.
$00000020 constant TRNG_TRNG_HEALTH_OSC3_SR_TO3_ADAPT_ERROR         \ Adaptive error flag of first oscillator of third triple-oscillator cell.


\
\ @brief TRNG_IRQ_CR register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant TRNG_TRNG_IRQ_CR_EN_FF_FULL_IRQ                  \ Enable the interrupt when the output fifo is full of new random.
$00000100 constant TRNG_TRNG_IRQ_CR_EN_ERROR_IRQ                    \ Enable the interrupt when an error is reported by the health tests.


\
\ @brief TRNG_IRQ_SR register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant TRNG_TRNG_IRQ_SR_FF_FULL_IRQ                     \ Set to 1 when the output fifo is full of new random. Flag is cleared by writing a 1.
$00000100 constant TRNG_TRNG_IRQ_SR_ERROR_IRQ                       \ Set to 1 when an error is reported by the health tests. Flag is cleared by writing a 1.


\
\ @brief TRNG
\
$48600000 constant TRNG_TRNG_CR   \ offset: 0x00 : TRNG_CR register
$48600004 constant TRNG_TRNG_SR   \ offset: 0x04 : TRNG_SR register
$48600008 constant TRNG_TRNG_VAL  \ offset: 0x08 : TRNG_VAL register
$48600030 constant TRNG_TRNG_OSCS_CR  \ offset: 0x30 : TRNG_OSCS_CR register
$48600034 constant TRNG_TRNG_POSTP_CR  \ offset: 0x34 : TRNG_POSTP_CR register
$48600038 constant TRNG_TRNG_POSTP_SR  \ offset: 0x38 : TRNG_POSTP_SR register
$48600040 constant TRNG_TRNG_DEFKEY0  \ offset: 0x40 : TRNG_DEFKEY0 register
$48600044 constant TRNG_TRNG_DEFKEY1  \ offset: 0x44 : TRNG_DEFKEY1 register
$48600048 constant TRNG_TRNG_DEFKEY2  \ offset: 0x48 : TRNG_DEFKEY2 register
$4860004c constant TRNG_TRNG_DEFKEY3  \ offset: 0x4C : TRNG_DEFKEY3 register
$48600060 constant TRNG_TRNG_HEALTH_CR  \ offset: 0x60 : TRNG_HEALTH_CR register
$48600068 constant TRNG_TRNG_HEALTH_OSC1_CR  \ offset: 0x68 : TRNG_HEALTH_OSC1_CR register
$4860006c constant TRNG_TRNG_HEALTH_OSC2_CR  \ offset: 0x6C : TRNG_HEALTH_OSC2_CR register
$48600070 constant TRNG_TRNG_HEALTH_OSC3_CR  \ offset: 0x70 : TRNG_HEALTH_OSC3_CR register
$48600074 constant TRNG_TRNG_HEALTH_OSC1_SR  \ offset: 0x74 : TRNG_HEALTH_OSC1_SR register
$48600078 constant TRNG_TRNG_HEALTH_OSC2_SR  \ offset: 0x78 : TRNG_HEALTH_OSC2_SR register
$4860007c constant TRNG_TRNG_HEALTH_OSC3_SR  \ offset: 0x7C : TRNG_HEALTH_OSC3_SR register
$48600080 constant TRNG_TRNG_IRQ_CR  \ offset: 0x80 : TRNG_IRQ_CR register
$48600084 constant TRNG_TRNG_IRQ_SR  \ offset: 0x84 : TRNG_IRQ_SR register

