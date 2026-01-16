\
\ @file sec_flash.fs
\ @brief Flash
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Access control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant SEC_FLASH_ACR_LATENCY                            \ Latency
$00002000 constant SEC_FLASH_ACR_RUN_PD                             \ Flash Power-down mode during Low-power run mode
$00004000 constant SEC_FLASH_ACR_SLEEP_PD                           \ Flash Power-down mode during Low-power sleep mode
$00008000 constant SEC_FLASH_ACR_LVEN                               \ LVEN


\
\ @brief Power down key register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_PDKEYR_PDKEYR                          \ RUN_PD in FLASH_ACR key


\
\ @brief Flash non-secure key register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_NSKEYR_NSKEYR                          \ NSKEYR


\
\ @brief Flash secure key register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_SECKEYR_SECKEYR                        \ SECKEYR


\
\ @brief Flash option key register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_OPTKEYR_OPTKEYR                        \ OPTKEYR


\
\ @brief Flash low voltage key register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_LVEKEYR_LVEKEYR                        \ LVEKEYR


\
\ @brief Flash status register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_NSSR_NSEOP                             \ NSEOP
$00000002 constant SEC_FLASH_NSSR_NSOPERR                           \ NSOPERR
$00000008 constant SEC_FLASH_NSSR_NSPROGERR                         \ NSPROGERR
$00000010 constant SEC_FLASH_NSSR_NSWRPERR                          \ NSWRPERR
$00000020 constant SEC_FLASH_NSSR_NSPGAERR                          \ NSPGAERR
$00000040 constant SEC_FLASH_NSSR_NSSIZERR                          \ NSSIZERR
$00000080 constant SEC_FLASH_NSSR_NSPGSERR                          \ NSPGSERR
$00002000 constant SEC_FLASH_NSSR_OPTWERR                           \ OPTWERR
$00008000 constant SEC_FLASH_NSSR_OPTVERR                           \ OPTVERR
$00010000 constant SEC_FLASH_NSSR_NSBSY                             \ NSBusy


\
\ @brief Flash status register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_SECSR_SECEOP                           \ SECEOP
$00000002 constant SEC_FLASH_SECSR_SECOPERR                         \ SECOPERR
$00000008 constant SEC_FLASH_SECSR_SECPROGERR                       \ SECPROGERR
$00000010 constant SEC_FLASH_SECSR_SECWRPERR                        \ SECWRPERR
$00000020 constant SEC_FLASH_SECSR_SECPGAERR                        \ SECPGAERR
$00000040 constant SEC_FLASH_SECSR_SECSIZERR                        \ SECSIZERR
$00000080 constant SEC_FLASH_SECSR_SECPGSERR                        \ SECPGSERR
$00004000 constant SEC_FLASH_SECSR_SECRDERR                         \ Secure read protection error
$00010000 constant SEC_FLASH_SECSR_SECBSY                           \ SECBusy


\
\ @brief Flash non-secure control register
\ Address offset: 0x28
\ Reset value: 0xC0000000
\

$00000001 constant SEC_FLASH_NSCR_NSPG                              \ NSPG
$00000002 constant SEC_FLASH_NSCR_NSPER                             \ NSPER
$00000004 constant SEC_FLASH_NSCR_NSMER1                            \ NSMER1
$000003f8 constant SEC_FLASH_NSCR_NSPNB                             \ NSPNB
$00000800 constant SEC_FLASH_NSCR_NSBKER                            \ NSBKER
$00008000 constant SEC_FLASH_NSCR_NSMER2                            \ NSMER2
$00010000 constant SEC_FLASH_NSCR_NSSTRT                            \ Options modification start
$00020000 constant SEC_FLASH_NSCR_OPTSTRT                           \ Options modification start
$01000000 constant SEC_FLASH_NSCR_NSEOPIE                           \ NSEOPIE
$02000000 constant SEC_FLASH_NSCR_NSERRIE                           \ NSERRIE
$08000000 constant SEC_FLASH_NSCR_OBL_LAUNCH                        \ Force the option byte loading
$40000000 constant SEC_FLASH_NSCR_OPTLOCK                           \ Options Lock
$80000000 constant SEC_FLASH_NSCR_NSLOCK                            \ NSLOCK


\
\ @brief Flash secure control register
\ Address offset: 0x2C
\ Reset value: 0x80000000
\

$00000001 constant SEC_FLASH_SECCR_SECPG                            \ SECPG
$00000002 constant SEC_FLASH_SECCR_SECPER                           \ SECPER
$00000004 constant SEC_FLASH_SECCR_SECMER1                          \ SECMER1
$000003f8 constant SEC_FLASH_SECCR_SECPNB                           \ SECPNB
$00000800 constant SEC_FLASH_SECCR_SECBKER                          \ SECBKER
$00008000 constant SEC_FLASH_SECCR_SECMER2                          \ SECMER2
$00010000 constant SEC_FLASH_SECCR_SECSTRT                          \ SECSTRT
$01000000 constant SEC_FLASH_SECCR_SECEOPIE                         \ SECEOPIE
$02000000 constant SEC_FLASH_SECCR_SECERRIE                         \ SECERRIE
$04000000 constant SEC_FLASH_SECCR_SECRDERRIE                       \ SECRDERRIE
$20000000 constant SEC_FLASH_SECCR_SECINV                           \ SECINV
$80000000 constant SEC_FLASH_SECCR_SECLOCK                          \ SECLOCK


\
\ @brief Flash ECC register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0007ffff constant SEC_FLASH_ECCR_ADDR_ECC                          \ ECC fail address
$00200000 constant SEC_FLASH_ECCR_BK_ECC                            \ BK_ECC
$00400000 constant SEC_FLASH_ECCR_SYSF_ECC                          \ SYSF_ECC
$01000000 constant SEC_FLASH_ECCR_ECCIE                             \ ECC correction interrupt enable
$10000000 constant SEC_FLASH_ECCR_ECCC2                             \ ECCC2
$20000000 constant SEC_FLASH_ECCR_ECCD2                             \ ECCD2
$40000000 constant SEC_FLASH_ECCR_ECCC                              \ ECC correction
$80000000 constant SEC_FLASH_ECCR_ECCD                              \ ECC detection


\
\ @brief Flash option register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000000ff constant SEC_FLASH_OPTR_RDP                               \ Read protection level
$00000700 constant SEC_FLASH_OPTR_BOR_LEV                           \ BOR reset Level
$00001000 constant SEC_FLASH_OPTR_NRST_STOP                         \ nRST_STOP
$00002000 constant SEC_FLASH_OPTR_NRST_STDBY                        \ nRST_STDBY
$00004000 constant SEC_FLASH_OPTR_NRST_SHDW                         \ nRST_SHDW
$00010000 constant SEC_FLASH_OPTR_IWDG_SW                           \ Independent watchdog selection
$00020000 constant SEC_FLASH_OPTR_IWDG_STOP                         \ Independent watchdog counter freeze in Stop mode
$00040000 constant SEC_FLASH_OPTR_IWDG_STDBY                        \ Independent watchdog counter freeze in Standby mode
$00080000 constant SEC_FLASH_OPTR_WWDG_SW                           \ Window watchdog selection
$00100000 constant SEC_FLASH_OPTR_SWAP_BANK                         \ SWAP_BANK
$00200000 constant SEC_FLASH_OPTR_DB256K                            \ DB256K
$00400000 constant SEC_FLASH_OPTR_DBANK                             \ DBANK
$01000000 constant SEC_FLASH_OPTR_SRAM2_PE                          \ SRAM2 parity check enable
$02000000 constant SEC_FLASH_OPTR_SRAM2_RST                         \ SRAM2 Erase when system reset
$04000000 constant SEC_FLASH_OPTR_NSWBOOT0                          \ nSWBOOT0
$08000000 constant SEC_FLASH_OPTR_NBOOT0                            \ nBOOT0
$10000000 constant SEC_FLASH_OPTR_PA15_PUPEN                        \ PA15_PUPEN
$80000000 constant SEC_FLASH_OPTR_TZEN                              \ TZEN


\
\ @brief Flash non-secure boot address 0 register
\ Address offset: 0x44
\ Reset value: 0x0000000F
\

$ffffff80 constant SEC_FLASH_NSBOOTADD0R_NSBOOTADD0                 \ NSBOOTADD0


\
\ @brief Flash non-secure boot address 1 register
\ Address offset: 0x48
\ Reset value: 0x0000000F
\

$ffffff80 constant SEC_FLASH_NSBOOTADD1R_NSBOOTADD1                 \ NSBOOTADD1


\
\ @brief FFlash secure boot address 0 register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_SECBOOTADD0R_BOOT_LOCK                 \ BOOT_LOCK
$ffffff80 constant SEC_FLASH_SECBOOTADD0R_SECBOOTADD0               \ SECBOOTADD0


\
\ @brief Flash bank 1 secure watermak1 register
\ Address offset: 0x50
\ Reset value: 0xFF00FF00
\

$0000007f constant SEC_FLASH_SECWM1R1_SECWM1_PSTRT                  \ SECWM1_PSTRT
$007f0000 constant SEC_FLASH_SECWM1R1_SECWM1_PEND                   \ SECWM1_PEND


\
\ @brief Flash secure watermak1 register 2
\ Address offset: 0x54
\ Reset value: 0x0F000F00
\

$0000007f constant SEC_FLASH_SECWM1R2_PCROP1_PSTRT                  \ PCROP1_PSTRT
$00008000 constant SEC_FLASH_SECWM1R2_PCROP1EN                      \ PCROP1EN
$007f0000 constant SEC_FLASH_SECWM1R2_HDP1_PEND                     \ HDP1_PEND
$80000000 constant SEC_FLASH_SECWM1R2_HDP1EN                        \ HDP1EN


\
\ @brief Flash Bank 1 WRP area A address register
\ Address offset: 0x58
\ Reset value: 0xFF00FF00
\

$0000007f constant SEC_FLASH_WRP1AR_WRP1A_PSTRT                     \ WRP1A_PSTRT
$007f0000 constant SEC_FLASH_WRP1AR_WRP1A_PEND                      \ WRP1A_PEND


\
\ @brief Flash Bank 1 WRP area B address register
\ Address offset: 0x5C
\ Reset value: 0xFF00FF00
\

$0000007f constant SEC_FLASH_WRP1BR_WRP1B_PSTRT                     \ WRP1B_PSTRT
$007f0000 constant SEC_FLASH_WRP1BR_WRP1B_PEND                      \ WRP1B_PEND


\
\ @brief Flash secure watermak2 register
\ Address offset: 0x60
\ Reset value: 0xFF00FF00
\

$0000007f constant SEC_FLASH_SECWM2R1_SECWM2_PSTRT                  \ SECWM2_PSTRT
$007f0000 constant SEC_FLASH_SECWM2R1_SECWM2_PEND                   \ SECWM2_PEND


\
\ @brief Flash secure watermak2 register2
\ Address offset: 0x64
\ Reset value: 0x0F000F00
\

$0000007f constant SEC_FLASH_SECWM2R2_PCROP2_PSTRT                  \ PCROP2_PSTRT
$00008000 constant SEC_FLASH_SECWM2R2_PCROP2EN                      \ PCROP2EN
$007f0000 constant SEC_FLASH_SECWM2R2_HDP2_PEND                     \ HDP2_PEND
$80000000 constant SEC_FLASH_SECWM2R2_HDP2EN                        \ HDP2EN


\
\ @brief Flash WPR2 area A address register
\ Address offset: 0x68
\ Reset value: 0xFF00FF00
\

$0000007f constant SEC_FLASH_WRP2AR_WRP2A_PSTRT                     \ WRP2A_PSTRT
$007f0000 constant SEC_FLASH_WRP2AR_WRP2A_PEND                      \ WRP2A_PEND


\
\ @brief Flash WPR2 area B address register
\ Address offset: 0x6C
\ Reset value: 0xFF00FF00
\

$0000007f constant SEC_FLASH_WRP2BR_WRP2B_PSTRT                     \ WRP2B_PSTRT
$007f0000 constant SEC_FLASH_WRP2BR_WRP2B_PEND                      \ WRP2B_PEND


\
\ @brief FLASH secure block based bank 1 register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_SECBB1R1_SECBB1                        \ SECBB1


\
\ @brief FLASH secure block based bank 1 register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_SECBB1R2_SECBB1                        \ SECBB1


\
\ @brief FLASH secure block based bank 1 register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_SECBB1R3_SECBB1                        \ SECBB1


\
\ @brief FLASH secure block based bank 1 register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_SECBB1R4_SECBB1                        \ SECBB1


\
\ @brief FLASH secure block based bank 2 register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_SECBB2R1_SECBB2                        \ SECBB2


\
\ @brief FLASH secure block based bank 2 register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_SECBB2R2_SECBB2                        \ SECBB2


\
\ @brief FLASH secure block based bank 2 register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_SECBB2R3_SECBB2                        \ SECBB2


\
\ @brief FLASH secure block based bank 2 register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant SEC_FLASH_SECBB2R4_SECBB2                        \ SECBB2


\
\ @brief FLASH secure HDP control register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_SECHDPCR_HDP1_ACCDIS                   \ HDP1_ACCDIS
$00000002 constant SEC_FLASH_SECHDPCR_HDP2_ACCDIS                   \ HDP2_ACCDIS


\
\ @brief Power privilege configuration register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000001 constant SEC_FLASH_PRIVCFGR_PRIV                          \ PRIV


\
\ @brief Flash
\
$50022000 constant SEC_FLASH_ACR  \ offset: 0x00 : Access control register
$50022004 constant SEC_FLASH_PDKEYR  \ offset: 0x04 : Power down key register
$50022008 constant SEC_FLASH_NSKEYR  \ offset: 0x08 : Flash non-secure key register
$5002200c constant SEC_FLASH_SECKEYR  \ offset: 0x0C : Flash secure key register
$50022010 constant SEC_FLASH_OPTKEYR  \ offset: 0x10 : Flash option key register
$50022014 constant SEC_FLASH_LVEKEYR  \ offset: 0x14 : Flash low voltage key register
$50022020 constant SEC_FLASH_NSSR  \ offset: 0x20 : Flash status register
$50022024 constant SEC_FLASH_SECSR  \ offset: 0x24 : Flash status register
$50022028 constant SEC_FLASH_NSCR  \ offset: 0x28 : Flash non-secure control register
$5002202c constant SEC_FLASH_SECCR  \ offset: 0x2C : Flash secure control register
$50022030 constant SEC_FLASH_ECCR  \ offset: 0x30 : Flash ECC register
$50022040 constant SEC_FLASH_OPTR  \ offset: 0x40 : Flash option register
$50022044 constant SEC_FLASH_NSBOOTADD0R  \ offset: 0x44 : Flash non-secure boot address 0 register
$50022048 constant SEC_FLASH_NSBOOTADD1R  \ offset: 0x48 : Flash non-secure boot address 1 register
$5002204c constant SEC_FLASH_SECBOOTADD0R  \ offset: 0x4C : FFlash secure boot address 0 register
$50022050 constant SEC_FLASH_SECWM1R1  \ offset: 0x50 : Flash bank 1 secure watermak1 register
$50022054 constant SEC_FLASH_SECWM1R2  \ offset: 0x54 : Flash secure watermak1 register 2
$50022058 constant SEC_FLASH_WRP1AR  \ offset: 0x58 : Flash Bank 1 WRP area A address register
$5002205c constant SEC_FLASH_WRP1BR  \ offset: 0x5C : Flash Bank 1 WRP area B address register
$50022060 constant SEC_FLASH_SECWM2R1  \ offset: 0x60 : Flash secure watermak2 register
$50022064 constant SEC_FLASH_SECWM2R2  \ offset: 0x64 : Flash secure watermak2 register2
$50022068 constant SEC_FLASH_WRP2AR  \ offset: 0x68 : Flash WPR2 area A address register
$5002206c constant SEC_FLASH_WRP2BR  \ offset: 0x6C : Flash WPR2 area B address register
$50022080 constant SEC_FLASH_SECBB1R1  \ offset: 0x80 : FLASH secure block based bank 1 register
$50022084 constant SEC_FLASH_SECBB1R2  \ offset: 0x84 : FLASH secure block based bank 1 register
$50022088 constant SEC_FLASH_SECBB1R3  \ offset: 0x88 : FLASH secure block based bank 1 register
$5002208c constant SEC_FLASH_SECBB1R4  \ offset: 0x8C : FLASH secure block based bank 1 register
$500220a0 constant SEC_FLASH_SECBB2R1  \ offset: 0xA0 : FLASH secure block based bank 2 register
$500220a4 constant SEC_FLASH_SECBB2R2  \ offset: 0xA4 : FLASH secure block based bank 2 register
$500220a8 constant SEC_FLASH_SECBB2R3  \ offset: 0xA8 : FLASH secure block based bank 2 register
$500220ac constant SEC_FLASH_SECBB2R4  \ offset: 0xAC : FLASH secure block based bank 2 register
$500220c0 constant SEC_FLASH_SECHDPCR  \ offset: 0xC0 : FLASH secure HDP control register
$500220c4 constant SEC_FLASH_PRIVCFGR  \ offset: 0xC4 : Power privilege configuration register

